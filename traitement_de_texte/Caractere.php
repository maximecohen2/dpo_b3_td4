<?php
class Caractere implements ICaractere{
    public function __construct($carac,$pol,$tail,$coul){
        $this->caractere = $carac; 
        $this->police = $pol;
        $this->taille = $tail;
        $this->couleur = $coul;
    }
    public function Afficher($position,$gras,$italique,$souligne,$majuscule){
        //print("position:".$position." gras:".$gras." italique:".$italique." souligne:".$souligne." maj:".$majuscule."<br>");
        //print("carac:".$this->caractere." police:".$this->police." taille:".$this->taille." couleur:".$this->couleur."<br>");
        $carac = $this->caractere;
        $container = "<span style='";
        $font_family = "font-family:".$this->police.";";
        $container .= $font_family;
        $container.="font-size:".$this->taille.";";
        $container.="color:".$this->couleur.";";
        if($gras){
            $container.="font-weight:bold;";
        }
        if($italique){
            $container.="font-style:italic;";
        }
        if($souligne){
            $container.="border-bottom:dotted 1px black;";
        }
        if($majuscule){
            $carac = strtoupper($carac);
        }
        $container.="'>";
        $container.=$carac;
        $container.="</span>";
        print($container);
    }
}
?>