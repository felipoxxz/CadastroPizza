function apagarPizza(id) {
    if (confirm('Confirma a exclus�o do registro?'))
    location.href = 'Pizza/Delete?id=' + id;
}
