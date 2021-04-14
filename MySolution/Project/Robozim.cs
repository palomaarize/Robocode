
using Robocode;
using System;
using System.Drawing;

namespace PSA
{
    public class Robozim : AdvancedRobot
    {

        public override void Run()
        {
            SetColors(Color.White, Color.Blue, Color.Red);

            TurnLeft(Heading - 90);

            TurnGunRight(90);

            while (true)
            {
                //ativar radar 360°
                TurnRadarRight(360);
            }
        }

        //O que o Robozim vai fazer quando estiver com outro na mira
        public override void OnScannedRobot(ScannedRobotEvent e)
        {


            // Se a energia do adversário for menor que 70 e a energia do adversario for maior 
            //que a do Robozim, ele ficará distante.
            if ((e.Energy < 70) && (e.Energy > Energy))
            {

                SetTurnGunRight(e.Bearing);

                if (e.Distance < 70)
                {
                    // precisa se afastar do inimigo e evitar o choque
                    if (e.Bearing > -90 && e.Bearing <= 90)
                    {
                        Back(60);
                    }
                    else
                    {
                        Ahead(60);
                    }
                }

                //Pega a direção que o chassi do Robozim está apontando em graus 
                //e soma com o angulo do robo adversário em relação ao Robozim.
                double superApontar = Heading + e.Bearing;

                // Pega o resultado da soma acima e passa por paramentro para a função AnguloNormal subrtraindo pela 
                //direção que a arma do Robozim esta apontando.
                double apontar = AnguloNormal(superApontar - GunHeading);

                //Se o valor retornado for menor ou igual a três.
                if (Math.Abs(apontar) <= 3)
                {
                    //Gira o canhão a direita passando o valor retornado do AnguloNormal.
                    TurnGunRight(apontar);
                    //Se a temperatura da arma for igual a zero.
                    if (GunHeat == 0)
                        //Abre fogo com a potencia três.
                        Fire(3);

                }
                else
                {
                    //Gira o canhão a direita passando o valor retornado do AnguloNormal.
                    TurnGunRight(apontar);
                    //Se a temperatura da arma for igual a zero.
                    if (GunHeat == 0)
                        //Analisa a arena em busca de outros adversários
                        Scan();
                }
            }
            else
            {
                //Gira o chassi do Robozim com o valor do angulo do adversário.
                SetTurnRight(e.Bearing);
                //Move o Robozima frente em relação a distancia do adversário
                SetAhead(e.Distance - 70);

                if (e.Distance < 50)
                {// precisa se afastar do inimigo e evitar o choque
                    if (e.Bearing > -90 && e.Bearing <= 90)
                    {
                        Back(60);
                    }
                    else
                    {
                        Ahead(60);
                    }
                }

                double superApontar = Heading + e.Bearing;
                double apontar = AnguloNormal(superApontar - GunHeading);

                if (Math.Abs(apontar) <= 3)
                {
                    //Gira o canhão a direita passando o valor retornado do AnguloNormal.
                    TurnGunRight(apontar);
                    //Se a temperatura da arma for igual a zero.
                    if (GunHeat == 0)
                        //Abre fogo com a potencia quatro.
                        Fire(Rules.MAX_BULLET_POWER);
                }
                else

                    TurnGunRight(apontar);
                //Se o valor retonado do AnguloNormal for igual igual a zero.
                if (apontar == 0)
                    //Analisa a arena em busca de outros adversários.
                    Scan();
            }

        }

        public double AnguloNormal(double angulo)
        {
            if ((angulo > -180) && (angulo <= 180))
                return (angulo);
            double anguloF = angulo;

            while (anguloF <= -180)
                anguloF += 360;
            while (anguloF > 180)
                anguloF -= 360;
            return (anguloF);
        }
    }
}
