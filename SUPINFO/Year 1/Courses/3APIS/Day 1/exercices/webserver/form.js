document.addEventListener("DOMContentLoaded", function () {
    let tasks = [];
    add_button = document.getElementById("add-btn");
    input_field = document.getElementById("input-field");

    add_button.addEventListener("click", function () {
        let taskText = input_field.value.trim();

        if (taskText === "") {
            alert("Please provide text for your task");
            return;
        }
        tasks[tasks.length] = taskText;
        input_field.value = "";
        updateTaskDisplay();
        console.log(tasks);
    });

    
    function updateTaskDisplay() {
    let taskList = document.getElementById("task-list");
    taskList.innerHTML = '';  

    for (let i = 0; i < tasks.length; i++) {
        let listItems = document.createElement("li");
        let listItemsRemoveButton = document.createElement("button")
        
        listItems.textContent = tasks[i];
        listItemsRemoveButton.textContent = "Remove";
        
        listItems.appendChild(listItemsRemoveButton);
        
        listItemsRemoveButton.addEventListener('click', function() {
            tasks.splice(i, 1);  // Remove task at position i
            updateTaskDisplay();  // Refresh display
        });
        
        taskList.appendChild(listItems);
    }
}
});
