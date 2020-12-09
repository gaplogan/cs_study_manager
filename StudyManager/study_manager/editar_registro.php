<?php

include "conexao.php";

$codigo = $_POST["codigo"];
$produto = $_POST["produto"];
$preco = $_POST["preco"];
$fabricante = $_POST["fabricante"];

$query = "UPDATE produto SET produto = '".$produto."', preco = '".$preco."', fabricante = '".$fabricante."' WHERE codigo = '".$codigo."'";
mysqli_query($conexao, $query) or die(mysqli_error());
mysqli_close($conexao);

?>