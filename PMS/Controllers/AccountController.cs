using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PMS.Models;

namespace PMS.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly ApplicationDbContext _context;

    public AccountController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        ApplicationDbContext context)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _context = context;
    }

    // REGISTER
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var identityUser = new IdentityUser
        {
            UserName = model.Username,
            Email = model.Email
        };

        var result = await _userManager.CreateAsync(identityUser, model.Password);

        if (result.Succeeded)
        {
            // Save into your custom User table
            var user = new User
            {
                IdentityId = identityUser.Id,
                Name = model.Username
            };

            _context.User.Add(user);
            await _context.SaveChangesAsync();

            await _signInManager.SignInAsync(identityUser, false);
            return RedirectToAction("Index", "Home");
        }

        foreach (var error in result.Errors)
            ModelState.AddModelError("", error.Description);

        return View(model);
    }

    // LOGIN
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var result = await _signInManager.PasswordSignInAsync(
            model.Username, model.Password, false, false);

        if (result.Succeeded)
            return RedirectToAction("Index", "Home");

        ModelState.AddModelError("", "Invalid login attempt");
        return View(model);
    }

    // LOGOUT
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Login");
    }
}
