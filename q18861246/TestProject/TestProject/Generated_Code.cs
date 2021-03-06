﻿// ----------------------------------------------------------------------------------------------
// Copyright (c) Mårten Rånge.
// ----------------------------------------------------------------------------------------------
// This source code is subject to terms and conditions of the Microsoft Public License. A 
// copy of the license can be found in the License.html file at the root of this distribution. 
// If you cannot locate the  Microsoft Public License, please send an email to 
// dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
//  by the terms of the Microsoft Public License.
// ----------------------------------------------------------------------------------------------
// You must not remove this notice, or any other, from this software.
// ----------------------------------------------------------------------------------------------



namespace TestProject
{
    
    partial struct ValidPercent
    {
        // Partial struct/class are great with T4 or any code-generation tool

        decimal m_value;

        // Partial methods are great to inject customized behavior into the generated code skeleton
        static partial void Partial_ValidateValue (decimal value);

        public ValidPercent (decimal value)
        {
            Partial_ValidateValue (value);
            m_value = value;
        }

        public decimal Value 
        {
            get
            {
                return m_value;
            }
            set
            {
                Partial_ValidateValue (value);
                m_value = value;
            }
        }

        public override string ToString ()
        {
            return Value + "%";
        }

    }
    
    partial struct Percent
    {
        // Partial struct/class are great with T4 or any code-generation tool

        decimal m_value;

        // Partial methods are great to inject customized behavior into the generated code skeleton
        static partial void Partial_ValidateValue (decimal value);

        public Percent (decimal value)
        {
            Partial_ValidateValue (value);
            m_value = value;
        }

        public decimal Value 
        {
            get
            {
                return m_value;
            }
            set
            {
                Partial_ValidateValue (value);
                m_value = value;
            }
        }

        public override string ToString ()
        {
            return Value + "%";
        }

    }

}
