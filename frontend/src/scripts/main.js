document.addEventListener('DOMContentLoaded', () => {
    const hamburgerButton = document.querySelector('.hamburger-button');
    const mainNav = document.querySelector('.main-nav');

    if (hamburgerButton && mainNav) {
        hamburgerButton.addEventListener('click', () => {
            mainNav.classList.toggle('is-open');

            const isOpen = mainNav.classList.contains('is-open');
            hamburgerButton.setAttribute('aria-expanded', isOpen);
        });
    }
});