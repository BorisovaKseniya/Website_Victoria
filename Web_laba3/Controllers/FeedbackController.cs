using System.Text;
using Microsoft.AspNetCore.Mvc;
using Web_laba3.DataContext;
using Web_laba3.Models;
namespace Web_laba3.Controllers
{
    [ApiController]
    [Route("feedback")]
    public class FeedbackController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public FeedbackController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpPost("submit")]
        public IActionResult SubmitFeedback([FromForm] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Feedback.Add(feedback);
                _context.SaveChanges();

                // Возвращаем HTML для уведомления и редиректа
                string script = @"
                    <script>
                        alert('Отзыв успешно отправлен!');
                        window.location.href = '../index.html';
                    </script>";
                return Content(script, "text/html", Encoding.UTF8);
            }

            // Если модель не валидна, возвращаем сообщение об ошибке
            string errorScript = @"
                <script>
                    alert('Ошибка при отправке отзыва. Проверьте данные и попробуйте снова.');
                    window.history.back();
                </script>";
            return Content(errorScript, "text/html");
        }
    }
}
       
