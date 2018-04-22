<?php
require('ICaractere.php');
require('Caractere.php');
require('CaractereFactory.php');

$caracFac = new CaractereFactory();

$carac1 = $caracFac->Créer("b","Arial",19,"black");
$carac1->Afficher(0,true,false,false,true);

$carac2 = $caracFac->Créer("o","Arial",19,"black");
$carac2->Afficher(1,false,false,false,false);

$carac3 = $caracFac->Créer("n","Arial",19,"black");
$carac3->Afficher(2,false,false,false,false);

$carac4 = $caracFac->Créer("j","Arial",19,"red");
$carac4->Afficher(3,false,false,false,false);

$carac5 = $caracFac->Créer("o","Arial",19,"black");
$carac5->Afficher(4,false,false,false,false);

$carac6 = $caracFac->Créer("u","Arial",19,"black");
$carac6->Afficher(5,false,false,false,false);

$carac7 = $caracFac->Créer("r","Arial",19,"black");
$carac7->Afficher(6,false,false,false,false);

?>