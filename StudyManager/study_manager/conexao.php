<?php

$hostname = "localhost";
$database = "study_manager";
$username = "logansm";
$password = "senha";

$conexao = new mysqli($hostname, $username, $password, $database);
if($conexao -> connect_errno){
	echo "Erro na conexão.";
}

?>