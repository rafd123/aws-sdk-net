/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using System;
    using System.Net;
    using System.Collections.Generic;
    using ThirdParty.Json.LitJson;
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for DescribeTrustedAdvisorCheckRefreshStatuses operation
      /// </summary>
      internal class DescribeTrustedAdvisorCheckRefreshStatusesResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          DescribeTrustedAdvisorCheckRefreshStatusesResponse response = new DescribeTrustedAdvisorCheckRefreshStatusesResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private static void UnmarshallResult(JsonUnmarshallerContext context,DescribeTrustedAdvisorCheckRefreshStatusesResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("statuses", targetDepth))
              {
                context.Read();
                
                if (context.CurrentTokenType == JsonToken.Null)
                {
                    response.Statuses = null;
                    continue;
                }
                  response.Statuses = new List<TrustedAdvisorCheckRefreshStatus>();
                  TrustedAdvisorCheckRefreshStatusUnmarshaller unmarshaller = TrustedAdvisorCheckRefreshStatusUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   response.Statuses.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {                   
                    return;
                }
            }
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
          {
            return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonAWSSupportException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeTrustedAdvisorCheckRefreshStatusesResponseUnmarshaller instance;
        public static DescribeTrustedAdvisorCheckRefreshStatusesResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new DescribeTrustedAdvisorCheckRefreshStatusesResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  