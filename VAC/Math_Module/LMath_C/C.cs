﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    public class C : Math_Field
    {
        #region Конструкторы

        public C(R r, R i)
        {

        }

        #endregion

        #region Поля
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private R real;
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private R image;

        #endregion

        #region Свойства

        public List<string> trigonomety
        {
            get
            {
                return null;
            }
        }

        public List<string> expotential
        {
            get
            {
                return null;
            }
        }

        #endregion

        #region Перегрузки

        public static C operator -(C value)
        {
            C clone = value.Clone();
            clone.real = -clone.real;
            clone.image = -clone.image;
            return clone;
        }

        public static C operator +(C first, C second)
        {
            C clone1 = first.Clone();
            C clone2 = second.Clone();
            clone1.real += clone2.real;
            clone1.image += clone2.image;
            return clone1;
        }

        public static C operator -(C first, C second)
        {
            C clone1 = first.Clone();
            C clone2 = second.Clone();
            return clone1 + (-clone2);
        }

        public static C operator *(C first, C second)
        {
            C clone1 = first.Clone();
            clone1.real = first.real * second.real - first.image * second.image;
            clone1.image = first.real * second.image + first.image * second.real;
            return clone1;
        }

        public static C operator /(C first, C second)
        {
            C clone1 = first.Clone();
            C clone2 = second.Clone();
            clone2.image = -clone2.image;
            clone1 *= clone2;
            clone1.real /= clone2.real * clone2.real + clone2.image * clone2.image;
            clone1.image /= clone2.real * clone2.real + clone2.image * clone2.image;
            return clone1;
        }

        public static implicit operator C(R value)
        {
            return null;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Создает точную копию данного объекта
        /// </summary>
        public C Clone() 
        {
            return null;
        }

        public static Math_Field Antiderivative_event_do(Math_Field value)
        {
            return ((C)(value as R)).ANT;
        }

        #endregion

        #region Событие

        public delegate Math_Field Antiderivative_delegate(Math_Field value);

        public static event Antiderivative_delegate Antiderivative_event;

        #endregion

        #region Общие свойства и методы

        #region Свойства
        public override int id
        {
            get
            {
                return 4;
            }
        }
        public override bool isDown 
        {
            get;
            
        }

        public override Math_Field ABS { get; }

        public override Math_Field UNT 
        {
            get 
            {
                return -this;
            } 
        }

        public override Math_Field DER { get; }

        public override Math_Field LED { get; }

        public override Math_Field DEG { get; }

        public override Math_Field ANT
        {
            get
            {
                return Antiderivative_event(this);
            }
        }

        #endregion

        #region Методы


        public override Math_Field Dawn()
        {
            return null;
        }

        public override Math_Field SUB(Math_Field second)
        {
            return this - (second as C);
        }

        public override Math_Field DIV(Math_Field second)
        {
            return this / (second as C);
        }

        public override Math_Field MOD(Math_Field second)
        {
            return null;
        }

        public override Math_Field ADD(Math_Field second)
        {
            return this + (second as C);
        }

        public override Math_Field MUL(Math_Field second)
        {
            return this * (second as C);
        }

        public override Math_Field GCF(Math_Field second)
        {
            return null;
        }

        public override Math_Field LCM(Math_Field second)
        {
            return null;
        }

        public override byte COM(Math_Field second)
        {
            return 0;
        }

        public override List<string> ToListstring()
        {
            return null;
        }

        public override Math_Field CEI(Math_Field first, Math_Field second)
        {
            try
            {
                return (ANT.RES(second) as C) - (ANT.RES(first) as C);
            }
            catch
            {
                return null;
            }
        }

        public override Math_Field RES(Math_Field value)
        {
            return this;
        }
        #endregion
        #endregion
    }
}
