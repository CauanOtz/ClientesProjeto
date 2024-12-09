function preencherEndereco(dados) {
    if (!("erro" in dados)) {
        $("#Logradouro").val(dados.logradouro);
        $("#Bairro").val(dados.bairro);
        $("#Cidade").val(dados.localidade);
        $("#UF").val(dados.uf);
    } else {
        alert("CEP não encontrado.");
        $("#Logradouro").val("");
        $("#Bairro").val("");
        $("#Cidade").val("");
        $("#UF").val("");
    }
}

$("#CEP").on("blur", function () {
    var cep = $(this).val().replace(/\D/g, '');
    if (cep.length === 8) {
        var url = `https://viacep.com.br/ws/${cep}/json/`;
        $.getJSON(url, function (dados) {
            preencherEndereco(dados);
        });
    } else {
        alert("CEP inválido.");
    }
});