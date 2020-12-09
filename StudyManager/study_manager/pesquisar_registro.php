<?php

include "conexao.php";

$codigo = $_GET["codigo"];

$query = "SELECT * FROM produto WHERE codigo = '$codigo'";
$resultado = $conexao -> query($query);

while($fila = $resultado -> fetch_array()){
	$produto[] = array_map('utf8_encode', $fila);
}

echo json_encode($produto);
$resultado -> close();

?>