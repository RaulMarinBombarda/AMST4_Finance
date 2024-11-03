document.getElementById('toggle-button').addEventListener('click', function () 
    document.body.classList.toggle('dark-mode');
    document.body.classList.toggle('light-mode');
    if (document.body.classList.contains('dark-mode')) {
        document.querySelector('table').classList.add('table-dark-mode');
        document.querySelector('table').classList.remove('table-light-mode');
    } else {
        document.querySelector('table').classList.add('table-light-mode');
        document.querySelector('table').classList.remove('table-dark-mode');
    }
});
