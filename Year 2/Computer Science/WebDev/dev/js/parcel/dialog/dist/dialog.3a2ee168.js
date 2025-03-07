const showButton = document.querySelector('#open-btn');
const modal = document.querySelector('#message');
const addButton = document.querySelector('#add-btn');
const content = document.querySelector('#content');
const closeButton = document.querySelector('#close-btn');
showButton.addEventListener('click', ()=>{
    modal.showModal();
//modal.showPopover();
});
closeButton.addEventListener('click', ()=>{
    modal.close();
});
let count = 0;
if (localStorage.getItem('count')) {
    count = Number(localStorage.getItem('count'));
    localStorage.setItem('count', count);
}
addButton.addEventListener('click', ()=>{
    const post = {
        title: 'Post title',
        content: 'Post content',
        tags: [
            'html',
            'css',
            'js'
        ]
    };
    localStorage.setItem('post', JSON.stringify(post));
    const postJson = localStorage.getItem('post');
    const postObj = JSON.parse(postJson);
    console.log(postObj);
    const p = document.createElement('p');
    p.textContent = `Paragraph ${count++}`;
    localStorage.setItem('count', count);
    content.append(p); // Change this line to append to the content element
});
const img = document.querySelector('img');
const fullBtn = document.querySelector('#full-btn'); // Change this line to use querySelector
const exitBtn = document.querySelector('#exitFullscreen-btn'); // Change this line to use querySelector
function fullScreen(elem) {
    if (elem.requestFullscreen) elem.requestFullscreen();
    else if (elem.webkitRequestFullscreen) elem.webkitRequestFullscreen();
    else if (elem.mozRequestFullscreen) elem.mozRequestFullscreen();
    else if (elem.msRequestFullscreen) elem.msRequestFullscreen();
}
fullBtn.addEventListener('click', ()=>{
    fullScreen(img);
});

//# sourceMappingURL=dialog.3a2ee168.js.map
