document.addEventListener('DOMContentLoaded', () => {
    const playButton = document.getElementById('play-btn');
    const pauseButton = document.getElementById('pause-btn');
    const audio = document.getElementById('background-music');
const box = document.getElementById('box');

    playButton.addEventListener('click', () => {
        audio.play();
box.classList.remove('paused');
    });

    pauseButton.addEventListener('click', () => {
        audio.pause();
box.classList.add('paused');
    });
});

const article = document.querySelector('article');
const addButton = document.querySelector('#add-btn');

addButton.addEventListener('click', () => {
    const p = document.createElement('p');
    p.textContent = 'New paragraph';
    p.classList.add('red');
    article.append(p);

}
);

    