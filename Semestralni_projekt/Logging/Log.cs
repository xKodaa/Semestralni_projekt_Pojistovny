using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestralni_projekt.Logging
{
    enum Log 
    {
        //Logy pro entitu OSOBA
        NAME_LENGTH_ERROR,
        NAME_FORMAT_ERROR, //nečíselný řetěžec
        SURNAME_LENGTH_ERROR, 
        SURNAME_FORMAT_ERROR, //nečíselný řetěžec
        NAME_ENTRY_SUCCESS,

        //Logy pro entitu ADRESA
        CITY_FORMAT_ERROR, //nečíselný řetěžec
        CITY_LENGTH_ERROR,
        STREET_FORMAT_ERROR, //nečíselný řetěžec
        STREET_LENGTH_ERROR,
        STREET_NUMBER_FORMAT_ERROR, //pouze čísla + '/' nebo '-'
        STREET_NUMBER_LENGTH_ERROR,
        POSTAL_CODE_FORMAT_ERROR, //pouze čísla bez mezer
        POSTAL_CODE_LENGTH_ERROR,
        CITY_ENTRY_SUCCESS,
        STREET_ENTRY_SUCCESS,
        STREET_NUMBER_ENTRY_SUCCES,
        POSTAL_CODE_ENTRY_SUCCESS
    }
}
