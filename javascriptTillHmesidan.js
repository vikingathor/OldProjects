document.addEventListener('DOMContentLoaded', function() {
    // Funktion för att uppdatera tiden
    function updateTime() {
        const now = new Date();
        const hours = now.getHours().toString().padStart(2, '0');
        const minutes = now.getMinutes().toString().padStart(2, '0');
        const seconds = now.getSeconds().toString().padStart(2, '0');
        const currentTime = `${hours}:${minutes}:${seconds}`;
        document.getElementById('current-time').textContent = currentTime;
    }

    // Uppdatera tiden direkt
    updateTime(); 
    // Uppdatera tiden varje sekund
    setInterval(updateTime, 1000);

    // Dropdown-meny logik
    document.querySelectorAll('.dropbtn').forEach(function(button) {
        button.addEventListener('click', function(event) {
            event.preventDefault();
            let dropdown = this.nextElementSibling;
            dropdown.style.display = dropdown.style.display === 'block' ? 'none' : 'block';
        });
    });

    window.addEventListener('click', function(event) {
        if (!event.target.matches('.dropbtn')) {
            document.querySelectorAll('.dropdown-content').forEach(function(dropdown) {
                dropdown.style.display = 'none';
            });
        }
    });
});
