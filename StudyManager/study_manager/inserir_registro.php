<?php

include "conexao.php";

$codigo = $_POST["codigo"];
$produto = $_POST["produto"];
$preco = $_POST["preco"];
$fabricante = $_POST["fabricante"];

$query = "INSERT INTO produto VALUES ('".$codigo."','".$produto."','".$preco."','".$fabricante."')";
mysqli_query($conexao, $query) or die (mysql_error());
mysqli_close($conexao);

?>