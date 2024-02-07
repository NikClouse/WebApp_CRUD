using Microsoft.AspNetCore.Mvc;
using WebApp_Test_CRUD.Models;

namespace WebApp_Test_CRUD.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: /users
        public IActionResult Index()
        {
            var users = _userRepository.GetAll();
            return View(users);
        }

        // GET: /users/details/{id}
        public IActionResult Details(int id)
        {
            var user = _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: /users/create
        public IActionResult Add()
        {
            return View();
        }

        // POST: /users/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.Add(user);
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // GET: /users/edit/{id}
        public IActionResult Update(int id)
        {
            var user = _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: /users/edit/{id}
        [HttpPost]

        public IActionResult Update(int id, User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _userRepository.Update(user);
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // GET: /users/delete/{id}
        public IActionResult Delete(int id)
        {
            _userRepository.Delete(id);
            return RedirectToAction(nameof(Index));

        }


    }
}
