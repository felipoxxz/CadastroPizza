function apagarPizza(id) {
    if (confirm('Confirma a exclusão do registro?'))
    location.href = 'Pizza/Delete?id=' + id;
}
