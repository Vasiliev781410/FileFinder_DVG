﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo
{
    /// <summary>
    /// Задача Модуля № 2
    ///    Организовать поиск файла по полному имени или поиск по паттерну.
    ///    Вычитать его как текстовый файл, сделать реверс на весь текст который внутри
    ///    и сохранить в то же место, где находился найденый файл но с добавкой к имени файла _reverse пример : filename_reverse.txt
    ///    Задание необходимо выполнить командой.
    ///    Как будет проверятся задание:
    ///    0 - Ваша программа должна работать.
    ///    1 - на трелло доске должны быть созданы таски с коротким описанием того что вы будете делать.
    ///[Module_01, Module_02, Module_03]
    ///2 - они должны быть зареплены за отдельным человеком и двигаться в статусах
    ///3 - я хочу видеть в гите 5 веток,
    ///мастер(пустой)[можно с.gitignore]
    ///релизка - (та где будет в итоге весь проекто полностю) сюда должны быть смерджены все ваши изменения
    ///и 3 фиче бранчи Module_01, Module_02, Module_03 - по названию тикетов на борде.
    /// 
    ///4 - вы создаете скайп чаты на команду и приглащаете туда меня, проводите минимум один созвон,
    ///  а там дальше на ваше усмотрение.было бы здорово видеть вашу активность в чате и нацеленность на завершение задания.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Данная программа это ClassLib и вы не сможете ее запустить :)
        /// Она является примером того как вы можете начать писать ваше приложение
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            IModuleTwoInvoker invoker = new ModuleTwoInvoker();

            //
            //Your code here
            //


            //NOTE:
            //В теориии вам должно хватить того что написанно + ваш код в местах где есть "//Your code here"  подобный комментарий :)
            //Вы можете изменять, удалять и создавать в  любой части этой программы если это поможет достижению вашей цели.
            //Не нужно делать ветки в этом репозитории ;) При желании - просто скопируйте код или файлы или всю библиотеку
        }
    }
}
