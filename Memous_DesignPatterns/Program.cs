﻿using System;

namespace Memous_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ctrl+R+A ни стартира тестовете директно!

            //Design patterns, main groups(Патърна дава терминология и описание на решението,
            //а не имплементация.Използвайки патърни вдигаме нивото на абстракция и спазваме СОЛИД принципите,
            //особено ОПЪН - Клоуз и Дипенданси инвършън принципа) 23 са основните
            //  (в книгата Ганг ъф фор са добре описани, но не е добре да започнем от нея тя е малко морално остаряла и с примери от C++), но има и други!!! По добра за нас според Ники е Head First Design Patterns - има я с Java и C#, но и с Java нямаме проблем - много си приличат. На много достъпен език е!!! Прилагат се само при - (не чупим орехи с валяк -овъркилл се нарича; -))!!!Решават проблеми като: да разкачим имплементации, да разкачим интерфейси, 
            //да вдигнем нивото на абстракция(бридж патърн - а).Доста от дизайн патърните са вкарани в езиците за
            //програмиране, като в C# (i в .NET:) Итератор патърна е IEnumerable. Обсървър патърна са Евентите в.NET.
            //Имената на патърните ни помагат и в комуникацията с колеги(на по - високо ниво на абстракцията комуникацията е по проста и бърза - с една две думи казваме повече неща)
            //С дизайн патърните преизползваме знания които вече са известни и доказани.Дизайн патърните са само част от патърните в
            //света на програмирането, има Секюрити патърни, Архитектурни патърни, Инфрастукторни патърни.Дизайн патърните са
            //концентрирани в проблеми свързани с ООП.Прилагайки патърна подобряваме качеството на кода(основна полза). 
            //Минуси са че:
            //-не водят до директна преизползваемост на кода(не можем просто да го копи-пейстнем);
            //-не са лесни за използване(не трябва да се ползват ако не са наистина нужни -така може да получим overdesign -излишно усложняване на кода);
            //-не трябва да се ползва ако не е нужно(това обикновенно го решават Синиарите)
            //Дизайн патърните в индустрията са нещо като стандарт.
            //Развивайки се ТРЯБВА да ги понаучим:
            //
            // Creational(казват как трябва да си подредим кода за да създаваме лесно и правилно обекти - Факчърита, Билдери)
            // - заместват new, if-овете т.е.вдигат абстракцията.

            //-Singleton - (гарантира ни една инстанция)за логери се ползва най - често, също за конзола, джойстик(когато правим нещо което е единствено) - прави една единствена инстанция (прост е, спорен е и но някои го наричат антипатерн). За всякъде където искаме да имаме една инстанция. Lazy може да ни помогне да го имплементираме. Singelton Jon Skeed хубава статия за Singleton.

            //- Simple Factory - най - простия дизайн патърн -ползвали сме го. Чрез Factory -то създаваме обект, като
            // не показваме на външния свят как -така крием детайлите -енкапсулираме и вдигаме нивото на абстракция.

            //- Factory Method ни позволява да вдигаме нивото на абстракция на Simple Factory - то.
            //Structural(казват как да структурираме вече съществуващи класове - как да комуникират за постигнем някаква функционалност.Свързано е с композицията на класове и обекти)

            //- Abstract Factory - вдига абстракцията още едно ниво, добавя методи и може да създава продукти дори и
            // да не са от една и съша фамилия.

            // -Builder - използваме го когато имаме стъпки(етапи) и точната им последователност за да построим нещо.
            // Има клас Директор, който знае последователността от стъпки която трябва да изпълним и който обикновенно работи с
            // някакъв абсрактен билдър.Можем да имаме различни Директори, които да работят с различни Билдъри.

            // -Prototype - това е клониране на вече съществуващ обект(Clone Method в.NET) имаме за тази работа(копира ми обект). Това return this не е копие (не е на друго място в паметта). В .NET имаме интерфейс за тази работа : IClonable и е добре да го използваме! Ползва се когато нещо се създава бавно! В .NET имаме метод който клонира обект, връща object и трябва да си го кастнем към каквото ни трябваа с as Пример : return this.MemberwiseClione() as ...., но да знаем не прави deep clone!!! Друг добър начин е с Рефлекшън и рекурсия - по-бавно е, но ще направи deep clone ако ни трябва! Serialization е друг подход за който ще говорим повече в DB.

            // -Fluent Interface(Linq) - това ще го виждаме много (и в ентити фреймлърк и в АСПНЕТ КОР). Много е популярен
            //защото има много предимства - като напиша нещо и Visual Studio ми подсказва с какво мога са продължа
            //(чейнването на функции/ команди). Ако искам да направя колекция: Enumerable.Range(1, 10).Where()...

            //Object Pool - използва се когато създаването на нов обект струва скъпо, когато създаването на обект изисква външни
            //ресурси (орваряне на файл, конекция към база данни която е прибрана и при нужда може да преизползвам, http връзка).

            //-Lazy Inicialization(В.NET си има клас за това – класа Lazy) – Казва ни как можем да създадем нещо в момента който ни потрябва(използва се за неща които са скъпи или трудни за създаване)

            //Structural Patterns (не се занимават със създаване на обекти)- занимават се с комбинацията на вече съществуващ код в общия случай или как можем да разширяваме съществуващ код, концентрирайки се върху връзките м/у самите класове. Двата основни начина са с наследяване и с композиция.

            //Facade (най - елементарния в тази категория) - Дава ни лесен достъп до сложна йерархия от класове (дава ни от по-високо ниво да използваме нещата). Най -често влиза в работа когато наши пърчета код (класове или методи) използват някаква библиотека. Фасадата ни прави допълнителен клас на тази библиотека в който изкарва основните и методи (пример за това е дистанционното за телевизора - то е фасада на нашия телевизор.). Идеята е че ние натискаме един бутон, но зад него са скрити последователност от функции които се случват без нас да ни интересуват. Фасадата ни скрива някаква сложна функционалност зад елементарни за ползване класове. В .NET с един метод в един клас (статичен дори можем да подадем един байт масив и парола и да ни го криптира, а ако я нямаше тази фасада трябваше да си правим крипто стрийм и още 4-5 класа за да криптираме нещо). 

            //Composite много използван и добър патърн позволява ни да правим дърво и дървовидни структори, които без значение дали имаме листо или компонент с наследници ги имплементираме по един и същи начин. Html, Xml i SortedDictionary са дървовидни структори. Всяко нещо с йерархична структора наричаме в програмирането дървовидна. Състои се от нещо общо (интерфейс или базов клас), "листо - worker" нещо което няма наследници и "компонент - divisionManager" който има наследници. Composite имаме на много места, например във потребителския интерфейс - VS - a всяко меню е композитно (може да си има подменюта).

            //DFS обхождане е depth first (първо слизаме в дълбочина), BFS bread first ще обходим на нива, това са алгуритми за обхождане.
            //Composite патърна ще направи DFS.

            //Flyweight ((подобен е на Object Pool) ни позволява да преизползваме неща (не ги създава) и ние не създаваме множество обекти но работим с много. Една инстанция се преизползва толкова пъти колкото ни е необходима. При текстове (Приммер:всяка бъква има една инстанция как се рисува и после се преизползва) и игри се ползва много често (Приммер: една плочка има една инстанция и после се визуализира на колкото места е необходимо).

            //Proxy интересен патърн, който ни позволява когато имаме нещо което върши работа и се подчинява на интерфейс да си направим клас нещоProxy който да имплементира същия интерфейс и да добави някаква функционалност преди да се свърши работата. Например ако работата е изтегляне на пари проверката ще е има ли достатъчно. Много често  Proxy - то извършва някаква валидация преди да извика оригиналния метод или клас който върши работата.


            //Decorator от любимите патърни на Ники защото позволява също да направим клас който да разширява функционалността на съществуващ клас държейки се отново като него, но ни позволява да добавяме един върху/в друг колкото са ни нужни декоратори. Типичния пример са стримовете в .NET (имаме стриймове които ни позволяват да разширим (екстенднем) даден стрийм) Пр.: Stream, GZipStream, CriptoStream, NetworkStream всяко може да е от всяко, Например: new GZip(Cripto(Network))) и това ще направи  NetworkStream, които ще го криптира и ще го компресира и мога да ги комбинирам както поискам - в каквато искам последователност. Без тези възможности за комбиниране с Decorator патерна бихме имали много повече класове (броят им расте експоненциално). Декорациите добавят функционалност - много ни развързват ръцете и се ползват доста и спазват Open Close принципа.

            //Adapter - много лесен дава ни възможност да си направим клас които имплементира наш интерфейс, а методите от нашия интерфейс ги  пренасочва към някакъв оригинален интерфейс или обект до който нямаме достъп. Адаптира наш интерфейс, който е от нашата структора на кода и прави нещо което се подчинява на нашия интерфейс, отдолу обаче използва нещо което е много далече от нас, т.е. !!! Правим нещо междинно което имплементира нашия интерфеис, но извиква методите от другия интерфейс!

            //Bridge той е най сложен от тези и вдига абстракцията и подобрява качеството на кода (не ни дава нова функционалност). Труден е за обясняване. Помага ни да спазим дипенданси инвършън принципа.

            // Behavioral(целят да постигнат ново поведение или комбинация от поведения) занимават се с взаимодействието м/у вече създадени обекти. На структурните концентрацията беше повече в/у класовете и интерфейсите и как те си взаимодействат помежду си, докато сега ще се занимаваме с функционалност в/у вече създадени обекти с комуникацията м/у тях. Основно имаме енкапсулация на поведение и създаване на структори от класове които искат да свършат някаква работа, делегиране, пренасяне на поведения. Това са от любимите патърни на Ники, защото са от по-интересните са и по-използвани защото решават по-често срещани проблеми.

            // - Chain of Responsibility - прилича на Composite патърна с разликата че Chain of Responsibility може да вземе решение дали да обработи заявката, дали да я даде на някой наследник, на всички наследници или на никой наследник! Това отново е дървовидна структора, но върху обектите (тук всеки знае за този над него , при Composite е обратното). Тук почваме от най-ниския и му казваме свърши тази работа, той преценява може ли да я свърши и ако да я върши, но ако не е длъжен да предаде работата на шефа си (на този над него).
            //texas hold em C# и в ГитХъба на Ники (за игра на покер) BestHend можем да разгледане хубав пример за Chain of Responsibility. 

            //Iterator - лекцията за Енумератори. Tрябва да има GetNext, HasNext, Current, Reset, т.е. през каквото и да итерираме трябва да збаем за следващия елемент. Iterator - скрива в себе си информацията как се минава от елемент на елемент (Yeld return генерира Енумератор). IEnumerable създава итератори в .NET и връща IEnumerator (iterator). IIterator интерфейс имаме също за създаване на Iterator. В C# си имаме форийч за тази работа.

            //Strategy Той е изключително елементарен, той е имплементазция на интерфейс с един метод например IEnumerable Sort (IEnumerable collection). Този интерфейс задава действие, например ISortAlgorithm. Strategy - то обикновено задава как ще изглежда един алгуритъм или някаква функционалност. Това е едно наследяване и абстракция, изнасяне на базов интерфейс и правене на негови наследници, които могат да имат следните имена QuickSort, BubbleSort и др. Дипенданси инвършън принципа е свързан със Strategy патърна.

            //Observer Използва се при различни събития, например промяна във файл (това е събитие  - в C# се нарича event) или потребителя мести мишката или е натиснал бутон - това са събития, неща които си се случват. Когато желаем да направим нещо при случването на някое от събитията използваме Observer патърна, казва ни как да решим този проблем (ако искаме да имаме събития и да се закачаме за тях). В C# използваме класа event.

            //Mediator (от тук стават по-сложни патърните - идеята им е проста, но имплементацията става по-сложна) РВД кулата на летищата играе ролята на медиатор (всеки самолет комуникира с нея и тя преценява за всеки, самолетите не комуникират помежду си). Mediator патърна разкача комуникацията всеки със всеки, т.е. медиатора играе не само ролята на посредник но и на филтър (филтрира излишния шум). Тук всеки участник знае за медиатора и комуникира само през медиатора, той не знае за и не комуникира с останалите участници (и не иска да знае), а медиатора знае за всички участници.

            //Memento използва клонирането, използва Prototype-а но се грижи не за създаването (Prototype създава) а за съхранението на копието. Често патърните работят в синхрон (като тук Memento не може да работи без Prototype). Идеята е интересна, защото Memento - то може да съхрани моментното състояние на даден обект или списък с моментни състояния на даден обект (в стек например). Това е много полезно и най-вече се използва за операциите Undo и Redo. Memento може да пази списъка на операции или команди които сме направили за да постигнем нещо. Важното е че  Memento-то винаги може да възтанови обекта в предишна негова версия, това е идеята. Идеята е да менажираме копия или списъци от стъпки които сме направили.

            //State Много интересен патърн, който ни позволява да направим т.нар. стейт машина или автомат. В математиката и програмирането стейт машината е нещо много приятно за ползване, но не толкова приятно за писане. Стейт машината се състои от състояния, като винаги си има Инишъл Стейт и всяко състояние си има преходи към друго състояние. Regular Expresions използват стейт машина. В дискретната математика много се решават автомати (стейт машина-и). 

            //Interpreter - много интересен и сложен патърн - използва се за да вземе нещо на един език и да го конвентира на друг, но езиците трябва да са формални - не може един интерпретатор да ни преведе от Български на Английски - те не са формални езици, нямат формални правила. Да си разгледам демата на Ники (много били яки - особено обратната полска нотация). 


            //Дизайн парърните са важни когато започнем да се изкачваме в йерархията, например от Регулар към Синиар. Засега да научим общо за какво са и един - два да импламентираме (ползваме) е ОК

            //Visitor позволява ни да  отворим дупки в нашия код за неща отвън, които могат да се извикват в дадени ситуации. Помага ни да спазим Open Close принципа - да отворим кода ни през такива Visitor - и за разширение отвън и да го затворим вътре да не се променя нашия код. Visitor-а е клас, който върши някаква работа. 

            //Command ни позволява да опишем някакво действие и да подчиня всички действия под един общ интерфейс.

            //В Ю Туб пишем design Patterns niki и ще ни излезнат подробни видеа !!!
            // Ако правим нещо което е силно вероятно след време някой да поиска да разширява доброто (високото) ниво на абстракция в кода е важно, ако ли не не е и не трябва за дребни неща за които не е нужно високо ниво на абстракция да я вдигаме.

            //UI - Юзер интерфейс техноилогии - Препоръчани от Ники за C# са !!!
            //Ако можем от windows forms да бягаме - бягаме, това е много остаряла технолгия. Съвременните технологии за UI които са много по добре направени и Ники препоръчва са: WPF за декстоп, Xamarin за мобилни приложения, UWP ако искаме да пишем приложения за стора на майкрософт, Unity ако искаме да пишем игри.
        }

    }
}
