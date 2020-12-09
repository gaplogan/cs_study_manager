<?php

include "conexao.php";

$codigo = $_POST["codigo"];

$query = "DELETE FROM produto WHERE codigo = '".$codigo."'";
mysqli_query($conexao, $query) or die (mysql_error());
mysqli_close($conexao);

?>