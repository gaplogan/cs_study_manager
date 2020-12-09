<?php

include "conexao.php";

$matricula = $_GET["matricula"];
$senha = $_GET["senha"];

$query = "SELECT * FROM usuarios WHERE matricula = '".$matricula."' AND senha = '".$senha."'";
$resultado = $conexao -> query($query);

while($fila = $resultado -> fetch_array()){
	$user[] = array_map('utf8_encode', $fila);
}

echo json_encode($user);
$resultado -> close();

?>