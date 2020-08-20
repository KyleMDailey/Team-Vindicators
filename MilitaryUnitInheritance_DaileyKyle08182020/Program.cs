//Authors:  Kyle Dailey, Tyler Kain, Florabel Ituralde, Tim Tieng (Team Vindicators)
//Date:  08/18/2020

/**************************************************************************************************************************************************************************************

Description:  This project contains code for the Military Unit Inheritance exercise.  It will create a console application which demonstrates inheritance.

***************************************************************************************************************************************************************************************

Revisions:  None

Revision Date:  N/A

Revised By:  N/A

***************************************************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnitInheritance_DaileyKyle08182020
{
    class Program
    {
        static void myTeamInfo()
        {
            Console.WriteLine("This is my Team!");
            Team myAlphaTeam = new Team();
            myAlphaTeam.rank = "SGT";
            myAlphaTeam.position = "Rifleman";
            myAlphaTeam.size = 4;
            myAlphaTeam.alphaTeam();

            Team myBravoTeam = new Team();// this is my squad
            myBravoTeam.rank = "CPL";
            myBravoTeam.position = "Grenadier";
            myBravoTeam.size = 3;
            myBravoTeam.bravoTeam();

            Console.WriteLine("This is my Squad!");
            Squad mySquad = new Squad();
            mySquad.rank = "SGT";
            mySquad.position = "Squad Leader";
            mySquad.PSG();
            mySquad.PLLeader();

            //Console.WriteLine($"My squad carries {lightWeapons}.");
            //Working to add a weapons interface.
        }

        static void Main()
        {
            try
            {
                myTeamInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("You did something wrong: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("AIRBORNE");
            }
        }
    }
}
