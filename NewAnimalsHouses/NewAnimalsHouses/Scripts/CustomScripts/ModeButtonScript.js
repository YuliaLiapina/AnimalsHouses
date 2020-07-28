let buttonDarkMode = document.querySelector('.dark-mode');
let buttonLightMode = document.createElement('button');

function DarkMode() {

    let bodyElement = document.querySelector('.Body');
    bodyElement.style.backgroundColor = 'black';

    let textElement = document.querySelector('.Body');
    textElement.style.color = 'white';

    buttonLightMode.className = 'light-mode';
    buttonLightMode.innerHTML = 'Light mode';

    buttonDarkMode.replaceWith(buttonLightMode);

    function LightMode() {
        bodyElement.style.backgroundColor = 'white';
        textElement.style.color = 'black';

        buttonLightMode.replaceWith(buttonDarkMode);

    }
    buttonLightMode.addEventListener('click', LightMode);
};

buttonDarkMode.addEventListener('click', DarkMode);
