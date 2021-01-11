﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "Revit MEP Sample Application" )]
[assembly: AssemblyDescription
  ( "Demonstrate use of the Revit API for MEP: "
  + "1. use of the generic API for HVAC specific tasks: "
  + "determine air terminals for each space; "
  + "assign flow to the air terminals depending on the space's calculated supply air flow; "
  + "change size of diffuser based on flow; "
  + "populate the value of the 'CFM per SF' variable on all spaces; "
  + "determine unhosted elements; "
  + "reset demo. "
  + "2. use of the MEP specific API to traverse an electrical system "
  + "and display its hierarchy in a tree view." )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "ADN Autodesk Developer Network, Autodesk, Inc." )]
[assembly: AssemblyProduct( "Revit MEP Sample Application" )]
[assembly: AssemblyCopyright( "Copyright © 2007-2021 by Jeremy Tammik, Autodesk, Inc." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "118f7279-630d-4661-afe5-c23c23acf46f" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
//
// History:
// 2014-09-02 2015.0.0.2 reformatted before removing obsolete API usage
// 2014-09-02 2015.0.0.3 removed obsolete API usage, specifically replaced Family.Symbols property by GetFamilySymbolIds
// 2014-09-02 2015.0.0.4 bumped the copyright message year from 2013 or whatever to 2014
// 2015-02-02 2015.0.0.5 bumped the copyright message year from 2014 to 2015
// 2015-06-04 2016.0.0.0 flat migration to Revit 2016
// 2016-04-13 2016.0.0.1 incremented copyright year from 2015 to 2016
// 2018-02-02 2018.0.0.0 migrated to Revit 2018, incremented copyright year, eliminated automatic transactions
// 2018-04-18 2019.0.0.0 migrated to Revit 2019
// 2020-11-05 2020.0.0.0 migrated to Revit 2020
// 2020-11-05 2021.0.0.0 flat migration to Revit 2021 API produces 11 deprecated API usage warnings
// 2020-11-05 2021.0.0.1 eliminated deprecated API usage
// 2021-01-11 2021.0.0.2 incremented copyright year
//
[assembly: AssemblyVersion( "2021.0.0.2" )]
[assembly: AssemblyFileVersion( "2021.0.0.2" )]
