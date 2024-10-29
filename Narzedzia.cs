/*
klasa: Narzedzia
opis: biblioteka narzedziowa
metody: Samogloski: zwara liczbę samogłosek znajdujących się w parametrze. Metoda przyjmuje jeden parametr będący ciągniem znaków( string)
autor: ja
*/
class Narzedzia {
    public static int Samogloski(string ciag_znakow){
        int licznik = 0;
        string samogloski = "aąeęiouóyAĄEĘIOUÓY";
        foreach(char x in ciag_znakow){
            if(samogloski.Contains(x)){
                licznik++;
            }
        }
        return licznik;
    }
}