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
            //  (в книгата Ганг ъф фор са добре описани), но има и други!!!Прилагат се само при нужда
            // (не чупим орехи с валяк -овъркилл се нарича; -))!!!Решават проблеми като: да разкачим имплементации, да разкачим интерфейси, 
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
            // Creational(казват как трябва да си подредим кода за да създаваме лесно и правилно обекти - Факчърита, Билдери)
            // - заместват new, if-овете т.е.вдигат абстракцията.
            //-Singleton - (гарантира ни една инстанция)за логери се ползва най - често, също за конзола, 
            // джойстик(когато правим нещо което е единствено) - прави една единствена инстанция(прост е, спорен е и но някои го наричат антипатерн).За всякъде където искаме да имаме една инстанция.

            //- Simple Factory - най - простия дизайн патърн -ползвали сме го. Чрез Factory -то създаваме обект, като
            // не показваме на външния свят как -така крием детайлите -енкапсулираме и вдигаме нивото на абстракция.

            //- Factory Method ни позволява да вдигаме нивото на абстракция на Simple Factory - то.
            //Structural(казват как да структурираме вече съществуващи класове - как да комуникират за да

            //постигнем някаква функционалност.Свързано е с композицията на класове и обекти)
            //- Abstract Factory - вдига абстракцията още едно ниво, добавя методи и може да създава продукти дори и
            // да не са от една и съша фамилия.
            // -Builder - използваме го когато имаме стъпки(етапи) и точната им последователност за да построим нещо.
            // Има клас Директор, който знае последователността от стъпки която трябва да изпълним и който обикновенно работи с
            // някакъв абсрактен билдър.Можем да имаме различни Директори, които да работят с различни Билдъри.
            // -Prototype - това е клониране на вече съществуващ обект(Clone Method в.NET) имаме за тази работа(копира ми обект).
            // -Fluent Interface(Linq) - това ще го виждаме много(и в ентити фреймлърк и в АСПНЕТ КОР). Много е популярен
            //защото има много предимства - като напиша нещо и Visual Studio ми подсказва с какво мога са продължа
            //(чейнването на функции/ команди). Ако искам да направя колекция: Enumerable.Range(1, 10).Where()...
            //Object Pool - използва се когато създаването на нов обект струва скъпо, когато създаването на обект изисква външни
            //ресурси (орваряне на файл, конекция към база данни която е прибрана и при нужда може да преизползвам, http връзка).
            //-Lazy Inicialization(В.NET си има клас за това – класа Lazy) – Казва ни как можем да създадем нещо в момента който ни потрябва(използва се за неща които са скъпи или трудни за създаване)


            // Behavioral(целят да постигнат ноо поведение или комбинация от поведения)
            // -

        }
}
