const inputText = document.querySelector('#input');
const addButton = document.querySelector('#add-btn');
const list = document.querySelector('#tasks');

function addTask() {
    if (inputText.value.trim() !== '') {

        const task = document.createElement('li');
        task.textContent = inputText.value;

        const deleteButton = document.createElement('a');
        deleteButton.textContent = '❌';
        deleteButton.href = '#';
        task.append(deleteButton);

        deleteButton.addEventListener('click', (e) => {
            e.preventDefault();
            task.remove();
        }
        );

        list.append(task);
        inputText.value = '';
        inputText.focus();
    }
}

addButton.addEventListener('click', addTask);

// list.addEventListener('click', (event) => {
//     event.target.remove();
// });

inputText.addEventListener('keydown', (event) => {
    if (event.key === 'Enter') {
        addTask();
    }
});
