document.getElementById('feedbackForm').addEventListener('submit', async (event) => {
    event.preventDefault(); // Предотвращаем стандартное поведение формы

    // Собираем данные из формы
    const formData = new FormData();
    const data = Object.fromEntries(formData);

    try {
        // Отправляем POST-запрос на ваш API
        const response = await fetch('api / feedback'), {
            method: 'POST',
            body: formData,
        });

        // Обрабатываем ответ
        if (response.ok) {
            const result = await response.text(); // Получаем HTML (ваш скрипт)
            document.body.innerHTML = result; // Отображаем результат на странице
        } else {
            alert('Ошибка при отправке отзыва. Попробуйте снова.');
        }
    } catch (error) {
        console.error('Ошибка:', error);
        alert('Произошла ошибка. Проверьте подключение к серверу.');
    }
});