/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.Runtime.Internal.Transform;    
    
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Result Unmarshaller for ModifyDBSubnetGroup operation
    /// </summary>
    internal class ModifyDBSubnetGroupResultUnmarshaller : IUnmarshaller<ModifyDBSubnetGroupResult, XmlUnmarshallerContext> {

        public ModifyDBSubnetGroupResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ModifyDBSubnetGroupResult result = new ModifyDBSubnetGroupResult();
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DBSubnetGroup", targetDepth))
                    {
                        result.DBSubnetGroup = DBSubnetGroupUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return result;
                }
            }
                       


            return result;
        }
        
        private static ModifyDBSubnetGroupResultUnmarshaller instance;
        
        public static ModifyDBSubnetGroupResultUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new ModifyDBSubnetGroupResultUnmarshaller();
            }
            return instance;
        }        
    }
}    
    
