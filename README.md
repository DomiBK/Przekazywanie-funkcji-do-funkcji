# Przekazywanie-funkcji-do-funkcji
Przekazywanie funkcji do funkcji jest przydatną techniką, która pozwala na elastyczniejsze i bardziej modułowe pisanie kodu. W C# można to osiągnąć poprzez użycie delegatów, wyrażeń lambda lub metod anonimowych.

Dlaczego warto przekazywać funkcję do funkcji?
Reużywalność kodu – zamiast pisać różne wersje tej samej funkcji, można przekazać różne funkcje jako argumenty, aby uzyskać różne zachowanie.
Modularność – kod staje się bardziej podzielny i zrozumiały, ponieważ odpowiedzialność za konkretne zadania jest podzielona na mniejsze funkcje.
Elastyczność – przekazując funkcje jako argumenty, możemy dynamicznie zmieniać sposób, w jaki funkcja działa, bez modyfikowania jej kodu.
Jak to zrobić w C#?
W C# można przekazywać funkcje do funkcji na kilka sposobów:

Używając delegatów – delegat to typ, który reprezentuje referencję do metody. Możemy zdefiniować delegata, a następnie przekazać do niego funkcję.
Używając wyrażeń lambda – wyrażenie lambda to wygodny sposób na zapisanie krótkich funkcji bez konieczności tworzenia pełnej definicji metody.
Używając metod anonimowych – podobne do lambdy, ale bardziej szczegółowe.
Przykład 1: Delegat jako parametr funkcji
Poniżej znajdziesz przykład pokazujący, jak przekazać funkcję do funkcji za pomocą delegata.




Wyjaśnienie:
Delegat Operation – definiuje, że funkcja musi przyjmować liczbę całkowitą i zwracać liczbę całkowitą.
Metoda ExecuteOperation – przyjmuje liczbę całkowitą i delegata jako argumenty, a następnie wywołuje funkcję przekazaną jako delegat.
Metody Square i Double – to dwie różne funkcje, które przekazujemy do ExecuteOperation.
Przykład 2: Wyrażenie lambda jako funkcja przekazana do funkcji
Wyrażenia lambda mogą być wygodnym sposobem definiowania funkcji "w locie". Zamiast tworzyć pełne metody, można użyć lambdy.


Wyjaśnienie:
Lambda x => x * x – wyrażenie lambda, które definiuje funkcję zwracającą kwadrat liczby.
Lambda x => x * 2 – wyrażenie lambda podwajające liczbę.
Lambda x => x + 10 – wyrażenie lambda dodające 10 do liczby.
Zadanie 1: Proste operacje matematyczne
Napisz program, w którym stworzysz funkcję PerformOperation, która przyjmuje jako argument liczbę całkowitą oraz delegata reprezentującego operację matematyczną. Następnie zdefiniuj kilka funkcji: dodawanie, odejmowanie, mnożenie i dzielenie, które będą przekazywane jako delegaty.


Kroki:

Zdefiniuj delegata MathOperation, który przyjmuje dwie liczby całkowite i zwraca liczbę całkowitą.
Zaimplementuj funkcję PerformOperation(int a, int b, MathOperation operation), która przyjmie dwie liczby oraz operację i zwróci wynik tej operacji.
Zdefiniuj cztery funkcje: Add, Subtract, Multiply, Divide, które wykonują odpowiednie operacje.
Przekaż te funkcje jako delegaty do funkcji PerformOperation i wyświetl wyniki.
Zadanie 2: Filtracja liczb
Stwórz funkcję FilterNumbers, która przyjmuje listę liczb całkowitych oraz delegata reprezentującego warunek filtrowania. Na podstawie przekazanego delegata, funkcja ma zwracać tylko te liczby, które spełniają określony warunek.



Kroki:

Zdefiniuj delegata FilterCondition, który przyjmuje liczbę całkowitą i zwraca wartość logiczną (bool).
Zaimplementuj funkcję FilterNumbers(List<int> numbers, FilterCondition condition), która zwróci listę liczb spełniających warunek.
Zdefiniuj trzy różne warunki filtrowania:
Liczby parzyste
Liczby większe od 10
Liczby mniejsze niż 0
Wyświetl wynik filtrowania dla każdej z tych funkcji.
Zadanie 3: Własna funkcja mapująca
Napisz funkcję Map, która przyjmuje listę liczb całkowitych oraz delegata, który przekształca każdą z tych liczb w inną. Zaimplementuj kilka funkcji, które będą mapować liczby, np. kwadrat liczby, podwojenie liczby, lub odjęcie jednej jednostki.



Kroki:

Zdefiniuj delegata Transform, który przyjmuje liczbę całkowitą i zwraca liczbę całkowitą.
Zaimplementuj funkcję Map(List<int> numbers, Transform transform), która zwróci nową listę przekształconych liczb.
Zdefiniuj trzy różne transformacje:
Funkcja zwracająca kwadrat liczby
Funkcja podwajająca liczbę
Funkcja odejmująca 1 od liczby
Zmapuj liczby z listy dla każdej z tych funkcji.
