const input = document.querySelector('#input');
// const displayBtn = document.querySelector('#btn');

const displayLink = document.querySelector('#fields a');

const output = document.querySelector('#output');

// output.style.width = '100px';

// displayBtn.addEventListener('click', () => {
//     output.textContent = input.value;
// });

displayLink.addEventListener('click', (e) => {
    e.preventDefault();
    displayLink.href = '#';
    displayLink.id = 'display-id';
    output.textContent = input.value;
    // codeImg.src = 'https://media.gettyimages.com/id/968350196/fr/photo/fortune-cookies-with-cartoon-eyes.jpg?s=612x612&w=gi&k=20&c=riSU_QNC1GmHWLhncaEowQsNYnMhuBh30u_I08KoT48=';
    if (output.classList.contains('red')) {
        output.classList.remove('red');
        output.classList.add('blue');
    }
    else {
        output.classList.remove('blue');
        output.classList.add('red');
    }
});

// const codeImg = document.querySelector('#code-img');

