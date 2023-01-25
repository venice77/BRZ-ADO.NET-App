# Opis wzorców projektowych

##Kompozyt

Wzorzec kompozytowy stosujemy dla hierarchicznej struktury obiektów, stanowiących pewne drzewo.
Wzorzec ten sprawdzi się szczególnie w sytuacji kiedy mamy do wykonania zadanie na każdym z obiektów.
Odwołując się do obiektu nadrzędnego, korzenia drzewa możemy rekursywnie wykonać działanie na wszystkich komponentach struktury.

##Obserwator

Wzorzec obserwatora, znany także jako Event-Subscriber to wzorzec który pozwala zdefiniować zależność oczekiwania obiektów jednej klasy na zdarzenie zachodzące na innym obiekcie
W momencie kiedy oczekiwane zdarzenie zajdzie, obiekt powinien poinformować oczekujących obserwatorów. W tym celu posiada on najczęściej listę subskrypcyjną, dzięki której właściwe obiekty są powiadamiane
Wzorzec ten może mieć szczególne znaczenie w przypadku zwiększania wydajności systemów czasu rzeczywistego.
Gdyby problem aktualności danych był realizowany przez systemowe bądź aplikacyjne usługi cron wywołujące odpowiedni endpoint API generowalibyśmy nadmiarowy ruch sieciowy i powodowali niepotrzebne eksploatowanie API.
W wariancie subskrypcji system oczekujący zmiany zostanie o niej powiadomiony we właściwym czasie bez konieczności odpytywania API

##Strategia

Wzorzec ten pozwala na uproszczenie eksploatacji kodu w przyszłości w przypadku chęci jego rozbudowy.
Zamiast modyfikować instniejącą klasę w celu implementacji nowej funkcjonalności wyrzucamy elementy które nie są wspólne do oddzielnych tras, stanowiących strategie.
Implementacja ta jest swego rodzaju "odwrotnością dziedziczenia"
Przykładem może być funkcja zwróć obiekt, a strategiami może być jego znalezienie po ID, nazwie bądź innym parametrze

##Metoda Wytwórcza

Wzorzec ten pozwala na łatwą implementację dodatkowych funkcjonalności poprzez tworzenie swego rodzaju klasy z abstrakcyjnym konstruktorem.
Konstruktor nie narzuca typu obiektu jaki ma być tworzony przy jego pomocy, a jedynie metody, które będą spójne dla klas po nim dziedziczących lub implementujących dany interfejs

##Dekorator

Wzorzec ten pozwala na zmodyfikowanie istniejącego obiektu o dodatkowe funkcjonalności poprzez opakowanie obiektu pierwotnego nowym, o rozszerzonych funkcjonalnościach.
Obiekt docelowy składa się z obiektu pierwotnego oraz zbioru dodatkowych pól i metod.
Wzorzez szczególnie przydatny w przypadku modyfikacji kodu, z którego obecnego stanu korzysta wiele innych obiektów. Nie psujemy w ten sposób działania innych części kodu.
