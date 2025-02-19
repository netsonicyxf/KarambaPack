﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace KarambaPack
{
    public class KarambaPackInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "KarambaPack";
            }
        }

        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }

        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "New components to exmpand the functionalities of the Karamba3d Plugin";
            }
        }

        public override Guid Id
        {
            get
            {
                return new Guid("c195e1f5-f3f7-4265-b636-2fdd1eff2b7e");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "Diego Apellániz";
            }
        }

        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "dapellanizq@gmail.com";
            }
        }

        public override string AssemblyVersion
        {
            get
            {
                return "1.0.3";
            }
        }
    }
}
