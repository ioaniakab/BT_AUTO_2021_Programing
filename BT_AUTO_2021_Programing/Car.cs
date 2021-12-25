﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Car
    {
        bool carStatus;
        double currentAcceleration;
        double direction;
        float fuelLevel;
        byte gear;
        float speed;
        ConsoleColor color;
        const byte MAX_GEAR = 6;
        string carBrand;

        public string CarBrand { get => carBrand; set => carBrand = value; }

        public Car(bool carStatus, double currentAcceleration, double direction)
        {
            this.carStatus = carStatus;
            this.currentAcceleration = currentAcceleration;
            this.direction = direction;
        }

        public Car()
        {
        }

        public Car(bool carStatus, double currentAcceleration, double direction, float fuelLevel, byte gear, float speed, ConsoleColor color) : this(carStatus, currentAcceleration, direction)
        {
            this.fuelLevel = fuelLevel;
            this.gear = gear;
            this.speed = speed;
            this.color = color;
        }

        public void Accelerate(double speedDelta)
        {
            currentAcceleration += speedDelta;
        }

        public void Decelerate(double speedDelta)
        {
            if (currentAcceleration  - speedDelta < 0)
            {
                currentAcceleration = 0;
            }
            else
            {
                currentAcceleration -= speedDelta;
            }
        }

        public void Steer(double angle)
        {
            direction += angle;
        }
        public void Accelerate()
        {
            currentAcceleration += 5;
        }

        public void Start()
        {
            carStatus = true;
        }

        public void Stop()
        {
            carStatus = false;
            speed = 0;
            gear = 0;
        }

        public void TurnLeft()
        {
            //direction -=90;
            Steer(-90);
        }

        public void TurnRight()
        {
            //direction += 90;
            Steer(90);
        }

        public void GearUp()
        {
            if(gear == MAX_GEAR)
            {
                Console.WriteLine("Cannot increase gear, we are at maxim gear: {0}", MAX_GEAR);
            }
            else
            {
                gear++;
            }
        }

        public void GearDown()
        {
            if(gear == 0)
            {
                Console.WriteLine("Already on gear 0, cannot decrease more!!");
            }
            else
            {
                gear++;
            }
        }
        public static double ConvertHPToKw(double hp)
        {
            return hp * 0.735499;
        }

        public void PrintCar()
        {
            Console.WriteLine("Current status of the car is: ");
            Console.WriteLine("GearLevel: {0}", gear);

            Console.WriteLine("Direction angle: {0}", direction);
            Console.WriteLine("Car status: {0}", carStatus);
            Console.WriteLine("");
        }

    }
}
