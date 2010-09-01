﻿//******************************************************************************************************
//  IsolatedStorageManager.cs - Gbtc
//
//  Copyright © 2010, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  09/01/2010 - Mehulbhai P Thakkar
//       Generated original version of source code.
//
//******************************************************************************************************

using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System;
using System.Text;

namespace openPDCManager.Utilities
{
    public static class IsolatedStorageManager
    {
        static IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly();
        
        public static void SaveInputMonitoringPoints(List<int> pointList)
        {
            using (StreamWriter writer = new StreamWriter(new IsolatedStorageFileStream("InputMonitoringPoints.txt", FileMode.Create, storage)))
            {
                StringBuilder sb = new StringBuilder();                
                foreach (int value in pointList)
                    sb.Append(value.ToString() + ";");

                writer.Write(sb.ToString());            
            }         
        }

        public static List<int> ReadInputMonitoringPoints()
        {
            List<int> pointList = new List<int>();
            using (StreamReader reader = new StreamReader(new IsolatedStorageFileStream("InputMonitoringPoints.txt", FileMode.OpenOrCreate, storage)))
            {
                if (reader != null)
                {
                    string result = reader.ReadToEnd();
                    string[] points = result.Split(new char[] { ';' });
                    foreach (string value in points)
                    {
                        if (!string.IsNullOrEmpty(value))
                            pointList.Add(Convert.ToInt32(value));
                    }
                }
            }

            return pointList;
        }
    }
}
