<?php
class CaractereFactory{
    public function Créer($caractere,$police,$taille,$couleur){
        $carac = new Caractere($caractere,$police,$taille,$couleur);
        return $carac;
    }
}
?>