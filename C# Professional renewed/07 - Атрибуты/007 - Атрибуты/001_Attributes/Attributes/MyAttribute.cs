﻿using System;

// Атрибуты. (Аспектно-Ориентированное Программирование)
// Атрибуты могут использоваться перед объявлениями типов, 
// членов класса, членов интерфейса и перечислений.
// Виды атрибутов: Предопределенные и Пользовательские.
// [ ....... ] - секция атрибута.
// Объявление атрибута состоит из Имени атрибута и набора Параметров.
// Для атрибутов определяют два вида параметров - Позиционные и Именованные. 
// Именованные параметры всегда располагаются после Позиционных.

namespace AttributeWork
{
    // Для создания атрибута необходимо создать класс производный от класса : System.Attribute.
    // Атрибут - [AttributeUsage] - задает свойства пользовательских атрибутов.
    // Позиционный параметр - AttributeTargets, определяет элементы программы, 
    // для которых атрибут может быть применен.
    // Параметр - AttributeTargets.All - позволяет использовать атрибут - MyAttribute, 
    // для любого элемента.
    // Именованный параметр - AllowMultiple = false, определяет сколько раз к одному элементу 
    // можно применять атрибут.
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class MyAttribute : System.Attribute
    {
        private readonly string date;
        public string Date
        {
            get { return date; }
        }

        // Позиционные параметры задаются формальными параметрами - public конструктора, класса атрибута.
        public MyAttribute(string date)
        {
            this.date = date;
        }

        // Именованные параметры задаются открытыми нестатическими полями или свойствами, класса атрибута.
        public int Number { get; set; }
    }
}