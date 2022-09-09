using CalidadT1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractica
{
    public class Pruebas
    {
        [Test]
        //CASO 01
        public void Caso01()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(1);

            Assert.AreEqual("I", max);
        }

        [Test]
        //CASO 02
        public void Caso02()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(5);

            Assert.AreEqual("V", max);
        }

        [Test]
        //CASO 03
        public void Caso03()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(0);

            Assert.AreEqual("no valido", max);
        }

        [Test]
        //CASO 04
        public void Caso04()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(-1);

            Assert.AreEqual("no valido", max);
        }

        [Test]
        //CASO 05
        public void Caso05()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(10);

            Assert.AreEqual("X", max);
        }

        [Test]
        //CASO 06
        public void Caso06()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(50);

            Assert.AreEqual("L", max);
        }

        [Test]
        //CASO 07
        public void Caso07()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(100);

            Assert.AreEqual("C", max);
        }

        [Test]
        //CASO 08
        public void Caso08()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(500);

            Assert.AreEqual("D", max);
        }

        [Test]
        //CASO 09
        public void Caso09()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(1000);

            Assert.AreEqual("M", max);
        }

        [Test]
        //CASO 10
        public void Caso10()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(1001);

            Assert.AreEqual("no valido", max);
        }

        [Test]
        //CASO 11
        public void Caso11()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(4);

            Assert.AreEqual("IV", max);
        }

        [Test]
        //CASO 12
        public void Caso12()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(9);

            Assert.AreEqual("IX", max);
        }

        [Test]
        //CASO 13
        public void Caso13()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(15);

            Assert.AreEqual("XV", max);
        }

        [Test]
        //CASO 14
        public void Caso14()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(3);

            Assert.AreEqual("III", max);
        }

        [Test]
        //CASO 15
        public void Caso15()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(20);

            Assert.AreEqual("XX", max);
        }

        [Test]
        //CASO 16
        public void Caso16()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(506);

            Assert.AreEqual("DVI", max);
        }

        [Test]
        //CASO 17
        public void Caso17()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(59);

            Assert.AreEqual("LIX", max);
        }

        [Test]
        //CASO 18
        public void Caso18()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(199);

            Assert.AreEqual("CXCIX", max);
        }

        [Test]
        //CASO 19
        public void Caso19()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(263);

            Assert.AreEqual("CCLXIII", max);
        }

        [Test]
        //CASO 20
        public void Caso20()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(534);

            Assert.AreEqual("DXXXIV", max);
        }

        [Test]
        //CASO 21
        public void Caso21()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(11);

            Assert.AreEqual("XI", max);
        }

        [Test]
        //CASO 22
        public void Caso22()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(40);

            Assert.AreEqual("XL", max);
        }

        [Test]
        //CASO 23
        public void Caso23()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(900);

            Assert.AreEqual("CM", max);
        }

        [Test]
        //CASO 24
        public void Caso24()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(401);

            Assert.AreEqual("CDI", max);
        }

        [Test]
        //CASO 25
        public void Caso25()
        {
            var romanos = new RomanoGenerator();
            var max = romanos.GetRomano(796);

            Assert.AreEqual("DCCXCVI", max);
        }
    }
}
