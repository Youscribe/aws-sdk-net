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
using System;
using System.Threading;

using Amazon.Route53.Model;
using Amazon.Route53.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.Route53
{
    /// <summary>
    /// Implementation for accessing AmazonRoute53.
    ///  
    /// 
    /// </summary>
    public class AmazonRoute53Client : AmazonWebServiceClient, AmazonRoute53
    {
    
        AbstractAWSSigner signer = new AWS3Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRoute53Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53Config() { RegionEndpoint = region }, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRoute53 Configuration Object</param>
        public AmazonRoute53Client(AmazonRoute53Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53Client(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53Config() { RegionEndpoint = region })
        {
        }


        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Credentials and an
        /// AmazonRoute53Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(AWSCredentials credentials, AmazonRoute53Config clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53Config() { RegionEndpoint = region })
        {
        }


        /// <summary>
        /// Constructs AmazonRoute53Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53Client Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53Client Configuration Object</param>
        public AmazonRoute53Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

        #endregion
   
        #region CreateHostedZone

        /// <summary>
        /// <para> This action creates a new hosted zone.</para> <para>To create a new hosted zone, send a <c>POST</c> request to the
        /// <c>2012-02-29/hostedzone</c> resource. The request body must include an XML document with a <c>CreateHostedZoneRequest</c> element. The
        /// response returns the <c>CreateHostedZoneResponse</c> element that contains metadata about the hosted zone.</para> <para>Route 53
        /// automatically creates a default SOA record and four NS records for the zone. The NS records in the hosted zone are the name servers you give
        /// your registrar to delegate your domain to. For more information about SOA and NS records, see NS and SOA Records that Route 53 Creates for a
        /// Hosted Zone in the <i>Amazon Route 53 Developer Guide</i> .</para> <para>When you create a zone, its initial status is <c>PENDING</c> . This
        /// means that it is not yet available on all DNS servers. The status of the zone changes to <c>INSYNC</c> when the NS and SOA records are
        /// available on all Route 53 DNS servers. </para>
        /// </summary>
        /// 
        /// <param name="createHostedZoneRequest">Container for the necessary parameters to execute the CreateHostedZone service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the CreateHostedZone service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="TooManyHostedZonesException"/>
        /// <exception cref="DelegationSetNotAvailableException"/>
        /// <exception cref="InvalidDomainNameException"/>
        /// <exception cref="HostedZoneAlreadyExistsException"/>
        /// <exception cref="InvalidInputException"/>
        public CreateHostedZoneResponse CreateHostedZone(CreateHostedZoneRequest createHostedZoneRequest)
        {
            IAsyncResult asyncResult = invokeCreateHostedZone(createHostedZoneRequest, null, null, true);
            return EndCreateHostedZone(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHostedZone operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.CreateHostedZone"/>
        /// </summary>
        /// 
        /// <param name="createHostedZoneRequest">Container for the necessary parameters to execute the CreateHostedZone operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHostedZone
        ///         operation.</returns>
        public IAsyncResult BeginCreateHostedZone(CreateHostedZoneRequest createHostedZoneRequest, AsyncCallback callback, object state)
        {
            return invokeCreateHostedZone(createHostedZoneRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateHostedZone operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.CreateHostedZone"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHostedZone.</param>
        /// 
        /// <returns>Returns a CreateHostedZoneResult from AmazonRoute53.</returns>
        public CreateHostedZoneResponse EndCreateHostedZone(IAsyncResult asyncResult)
        {
            return endOperation<CreateHostedZoneResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateHostedZone(CreateHostedZoneRequest createHostedZoneRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateHostedZoneRequestMarshaller().Marshall(createHostedZoneRequest);
            var unmarshaller = CreateHostedZoneResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListHostedZones

        /// <summary>
        /// <para> To retrieve a list of your hosted zones, send a <c>GET</c> request to the <c>2012-02-29/hostedzone</c> resource. The response to this
        /// request includes a <c>HostedZones</c> element with zero, one, or multiple <c>HostedZone</c> child elements. By default, the list of hosted
        /// zones is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c> parameter. You
        /// can use the <c>Marker</c> parameter to control the hosted zone that the list begins with. </para> <para><b>NOTE:</b> Amazon Route 53 returns
        /// a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
        /// </summary>
        /// 
        /// <param name="listHostedZonesRequest">Container for the necessary parameters to execute the ListHostedZones service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        public ListHostedZonesResponse ListHostedZones(ListHostedZonesRequest listHostedZonesRequest)
        {
            IAsyncResult asyncResult = invokeListHostedZones(listHostedZonesRequest, null, null, true);
            return EndListHostedZones(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListHostedZones operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.ListHostedZones"/>
        /// </summary>
        /// 
        /// <param name="listHostedZonesRequest">Container for the necessary parameters to execute the ListHostedZones operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHostedZones
        ///         operation.</returns>
        public IAsyncResult BeginListHostedZones(ListHostedZonesRequest listHostedZonesRequest, AsyncCallback callback, object state)
        {
            return invokeListHostedZones(listHostedZonesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListHostedZones operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.ListHostedZones"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHostedZones.</param>
        /// 
        /// <returns>Returns a ListHostedZonesResult from AmazonRoute53.</returns>
        public ListHostedZonesResponse EndListHostedZones(IAsyncResult asyncResult)
        {
            return endOperation<ListHostedZonesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListHostedZones(ListHostedZonesRequest listHostedZonesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListHostedZonesRequestMarshaller().Marshall(listHostedZonesRequest);
            var unmarshaller = ListHostedZonesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> To retrieve a list of your hosted zones, send a <c>GET</c> request to the <c>2012-02-29/hostedzone</c> resource. The response to this
        /// request includes a <c>HostedZones</c> element with zero, one, or multiple <c>HostedZone</c> child elements. By default, the list of hosted
        /// zones is displayed on a single page. You can control the length of the page that is displayed by using the <c>MaxItems</c> parameter. You
        /// can use the <c>Marker</c> parameter to control the hosted zone that the list begins with. </para> <para><b>NOTE:</b> Amazon Route 53 returns
        /// a maximum of 100 items. If you set MaxItems to a value greater than 100, Amazon Route 53 returns only the first 100.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHostedZones service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        public ListHostedZonesResponse ListHostedZones()
        {
            return ListHostedZones(new ListHostedZonesRequest());
        }
        

        #endregion
    
        #region ChangeResourceRecordSets

        /// <summary>
        /// <para>Use this action to create or change your authoritative DNS information. To use this action, send a <c>POST</c> request to the
        /// <c>2012-02-29/hostedzone/hosted Zone ID/rrset</c> resource. The request body must include an XML document with a
        /// <c>ChangeResourceRecordSetsRequest</c> element.</para> <para>Changes are a list of change items and are considered transactional. For more
        /// information on transactional changes, also known as change batches, see Creating, Changing, and Deleting Resource Record Sets Using the
        /// Route 53 API in the <i>Amazon Route 53 Developer Guide</i> .</para> <para><b>IMPORTANT:</b>Due to the nature of transactional changes, you
        /// cannot delete the same resource record set more than once in a single change batch. If you attempt to delete the same change batch more than
        /// once, Route 53 returns an InvalidChangeBatch error.</para> <para>In response to a <c>ChangeResourceRecordSets</c> request, your DNS data is
        /// changed on all Route 53 DNS servers. Initially, the status of a change is <c>PENDING</c> . This means the change has not yet propagated to
        /// all the authoritative Route 53 DNS servers. When the change is propagated to all hosts, the change returns a status of <c>INSYNC</c>
        /// .</para> <para>Note the following limitations on a <c>ChangeResourceRecordSets</c> request:</para> <para>- A request cannot contain more
        /// than 100 Change elements.</para> <para>- A request cannot contain more than 1000 ResourceRecord elements.</para> <para>The sum of the number
        /// of characters (including spaces) in all <c>Value</c> elements in a request cannot exceed 32,000 characters.</para>
        /// </summary>
        /// 
        /// <param name="changeResourceRecordSetsRequest">Container for the necessary parameters to execute the ChangeResourceRecordSets service method
        ///          on AmazonRoute53.</param>
        /// 
        /// <returns>The response from the ChangeResourceRecordSets service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidChangeBatchException"/>
        /// <exception cref="NoSuchHostedZoneException"/>
        /// <exception cref="InvalidInputException"/>
        public ChangeResourceRecordSetsResponse ChangeResourceRecordSets(ChangeResourceRecordSetsRequest changeResourceRecordSetsRequest)
        {
            IAsyncResult asyncResult = invokeChangeResourceRecordSets(changeResourceRecordSetsRequest, null, null, true);
            return EndChangeResourceRecordSets(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.ChangeResourceRecordSets"/>
        /// </summary>
        /// 
        /// <param name="changeResourceRecordSetsRequest">Container for the necessary parameters to execute the ChangeResourceRecordSets operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndChangeResourceRecordSets operation.</returns>
        public IAsyncResult BeginChangeResourceRecordSets(ChangeResourceRecordSetsRequest changeResourceRecordSetsRequest, AsyncCallback callback, object state)
        {
            return invokeChangeResourceRecordSets(changeResourceRecordSetsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ChangeResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.ChangeResourceRecordSets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeResourceRecordSets.</param>
        /// 
        /// <returns>Returns a ChangeResourceRecordSetsResult from AmazonRoute53.</returns>
        public ChangeResourceRecordSetsResponse EndChangeResourceRecordSets(IAsyncResult asyncResult)
        {
            return endOperation<ChangeResourceRecordSetsResponse>(asyncResult);
        }
        
        IAsyncResult invokeChangeResourceRecordSets(ChangeResourceRecordSetsRequest changeResourceRecordSetsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ChangeResourceRecordSetsRequestMarshaller().Marshall(changeResourceRecordSetsRequest);
            var unmarshaller = ChangeResourceRecordSetsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetChange

        /// <summary>
        /// <para> This action returns the current status of a change batch request. The status is one of the following values:</para> <para>-
        /// <c>PENDING</c> indicates that the changes in this request have not replicated to all Route 53 DNS servers. This is the initial status of all
        /// change batch requests.</para> <para>- <c>INSYNC</c> indicates that the changes have replicated to all Amazon Route 53 DNS servers. </para>
        /// </summary>
        /// 
        /// <param name="getChangeRequest">Container for the necessary parameters to execute the GetChange service method on AmazonRoute53.</param>
        /// 
        /// <returns>The response from the GetChange service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="NoSuchChangeException"/>
        public GetChangeResponse GetChange(GetChangeRequest getChangeRequest)
        {
            IAsyncResult asyncResult = invokeGetChange(getChangeRequest, null, null, true);
            return EndGetChange(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetChange operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.GetChange"/>
        /// </summary>
        /// 
        /// <param name="getChangeRequest">Container for the necessary parameters to execute the GetChange operation on AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChange
        ///         operation.</returns>
        public IAsyncResult BeginGetChange(GetChangeRequest getChangeRequest, AsyncCallback callback, object state)
        {
            return invokeGetChange(getChangeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetChange operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.GetChange"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChange.</param>
        /// 
        /// <returns>Returns a GetChangeResult from AmazonRoute53.</returns>
        public GetChangeResponse EndGetChange(IAsyncResult asyncResult)
        {
            return endOperation<GetChangeResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetChange(GetChangeRequest getChangeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetChangeRequestMarshaller().Marshall(getChangeRequest);
            var unmarshaller = GetChangeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListResourceRecordSets

        /// <summary>
        /// <para>Imagine all the resource record sets in a zone listed out in front of you. Imagine them sorted lexicographically first by DNS name
        /// (with the labels reversed, like "com.amazon.www" for example), and secondarily, lexicographically by record type. This operation retrieves
        /// at most MaxItems resource record sets from this list, in order, starting at a position specified by the Name and Type arguments:</para>
        /// <ul>
        /// <li>If both Name and Type are omitted, this means start the results at the first RRSET in the HostedZone.</li>
        /// <li>If Name is specified but Type is omitted, this means start the results at the first RRSET in the list whose name is greater than or
        /// equal to Name. </li>
        /// <li>If both Name and Type are specified, this means start the results at the first RRSET in the list whose name is greater than or equal to
        /// Name and whose type is greater than or equal to Type.</li>
        /// <li>It is an error to specify the Type but not the Name.</li>
        /// 
        /// </ul>
        /// <para>Use ListResourceRecordSets to retrieve a single known record set by specifying the record set's name and type, and setting MaxItems =
        /// 1</para> <para>To retrieve all the records in a HostedZone, first pause any processes making calls to ChangeResourceRecordSets. Initially
        /// call ListResourceRecordSets without a Name and Type to get the first page of record sets. For subsequent calls, set Name and Type to the
        /// NextName and NextType values returned by the previous response. </para> <para>In the presence of concurrent ChangeResourceRecordSets calls,
        /// there is no consistency of results across calls to ListResourceRecordSets. The only way to get a consistent multi-page snapshot of all
        /// RRSETs in a zone is to stop making changes while pagination is in progress.</para> <para>However, the results from ListResourceRecordSets
        /// are consistent within a page. If MakeChange calls are taking place concurrently, the result of each one will either be completely visible in
        /// your results or not at all. You will not see partial changes, or changes that do not ultimately succeed. (This follows from the fact that
        /// MakeChange is atomic) </para> <para>The results from ListResourceRecordSets are strongly consistent with ChangeResourceRecordSets. To be
        /// precise, if a single process makes a call to ChangeResourceRecordSets and receives a successful response, the effects of that change will be
        /// visible in a subsequent call to ListResourceRecordSets by that process.</para>
        /// </summary>
        /// 
        /// <param name="listResourceRecordSetsRequest">Container for the necessary parameters to execute the ListResourceRecordSets service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the ListResourceRecordSets service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="NoSuchHostedZoneException"/>
        /// <exception cref="InvalidInputException"/>
        public ListResourceRecordSetsResponse ListResourceRecordSets(ListResourceRecordSetsRequest listResourceRecordSetsRequest)
        {
            IAsyncResult asyncResult = invokeListResourceRecordSets(listResourceRecordSetsRequest, null, null, true);
            return EndListResourceRecordSets(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.ListResourceRecordSets"/>
        /// </summary>
        /// 
        /// <param name="listResourceRecordSetsRequest">Container for the necessary parameters to execute the ListResourceRecordSets operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListResourceRecordSets operation.</returns>
        public IAsyncResult BeginListResourceRecordSets(ListResourceRecordSetsRequest listResourceRecordSetsRequest, AsyncCallback callback, object state)
        {
            return invokeListResourceRecordSets(listResourceRecordSetsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListResourceRecordSets operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.ListResourceRecordSets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceRecordSets.</param>
        /// 
        /// <returns>Returns a ListResourceRecordSetsResult from AmazonRoute53.</returns>
        public ListResourceRecordSetsResponse EndListResourceRecordSets(IAsyncResult asyncResult)
        {
            return endOperation<ListResourceRecordSetsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListResourceRecordSets(ListResourceRecordSetsRequest listResourceRecordSetsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListResourceRecordSetsRequestMarshaller().Marshall(listResourceRecordSetsRequest);
            var unmarshaller = ListResourceRecordSetsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetHostedZone

        /// <summary>
        /// <para> To retrieve the delegation set for a hosted zone, send a <c>GET</c> request to the <c>2012-02-29/hostedzone/hosted zone ID </c>
        /// resource. The delegation set is the four Route 53 name servers that were assigned to the hosted zone when you created it.</para>
        /// </summary>
        /// 
        /// <param name="getHostedZoneRequest">Container for the necessary parameters to execute the GetHostedZone service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the GetHostedZone service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="NoSuchHostedZoneException"/>
        /// <exception cref="InvalidInputException"/>
        public GetHostedZoneResponse GetHostedZone(GetHostedZoneRequest getHostedZoneRequest)
        {
            IAsyncResult asyncResult = invokeGetHostedZone(getHostedZoneRequest, null, null, true);
            return EndGetHostedZone(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostedZone operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.GetHostedZone"/>
        /// </summary>
        /// 
        /// <param name="getHostedZoneRequest">Container for the necessary parameters to execute the GetHostedZone operation on AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostedZone
        ///         operation.</returns>
        public IAsyncResult BeginGetHostedZone(GetHostedZoneRequest getHostedZoneRequest, AsyncCallback callback, object state)
        {
            return invokeGetHostedZone(getHostedZoneRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetHostedZone operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.GetHostedZone"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostedZone.</param>
        /// 
        /// <returns>Returns a GetHostedZoneResult from AmazonRoute53.</returns>
        public GetHostedZoneResponse EndGetHostedZone(IAsyncResult asyncResult)
        {
            return endOperation<GetHostedZoneResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetHostedZone(GetHostedZoneRequest getHostedZoneRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetHostedZoneRequestMarshaller().Marshall(getHostedZoneRequest);
            var unmarshaller = GetHostedZoneResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteHostedZone

        /// <summary>
        /// <para>This action deletes a hosted zone. To delete a hosted zone, send a <c>DELETE</c> request to the <c>2012-02-29/hostedzone/hosted zone
        /// ID </c> resource.</para> <para>For more information about deleting a hosted zone, see Deleting a Hosted Zone in the Amazon Route 53
        /// Developer Guide.</para> <para><b>IMPORTANT:</b> You can delete a hosted zone only if there are no resource record sets other than the
        /// default SOA record and NS resource record sets. If your hosted zone contains other resource record sets, you must delete them before you can
        /// delete your hosted zone. If you try to delete a hosted zone that contains other resource record sets, Route 53 will deny your request with a
        /// HostedZoneNotEmpty error. For information about deleting records from your hosted zone, see ChangeResourceRecordSets.</para>
        /// </summary>
        /// 
        /// <param name="deleteHostedZoneRequest">Container for the necessary parameters to execute the DeleteHostedZone service method on
        ///          AmazonRoute53.</param>
        /// 
        /// <returns>The response from the DeleteHostedZone service method, as returned by AmazonRoute53.</returns>
        /// 
        /// <exception cref="HostedZoneNotEmptyException"/>
        /// <exception cref="NoSuchHostedZoneException"/>
        /// <exception cref="InvalidInputException"/>
        public DeleteHostedZoneResponse DeleteHostedZone(DeleteHostedZoneRequest deleteHostedZoneRequest)
        {
            IAsyncResult asyncResult = invokeDeleteHostedZone(deleteHostedZoneRequest, null, null, true);
            return EndDeleteHostedZone(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHostedZone operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.DeleteHostedZone"/>
        /// </summary>
        /// 
        /// <param name="deleteHostedZoneRequest">Container for the necessary parameters to execute the DeleteHostedZone operation on
        ///          AmazonRoute53.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHostedZone
        ///         operation.</returns>
        public IAsyncResult BeginDeleteHostedZone(DeleteHostedZoneRequest deleteHostedZoneRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteHostedZone(deleteHostedZoneRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteHostedZone operation.
        /// <seealso cref="Amazon.Route53.AmazonRoute53.DeleteHostedZone"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHostedZone.</param>
        /// 
        /// <returns>Returns a DeleteHostedZoneResult from AmazonRoute53.</returns>
        public DeleteHostedZoneResponse EndDeleteHostedZone(IAsyncResult asyncResult)
        {
            return endOperation<DeleteHostedZoneResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteHostedZone(DeleteHostedZoneRequest deleteHostedZoneRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteHostedZoneRequestMarshaller().Marshall(deleteHostedZoneRequest);
            var unmarshaller = DeleteHostedZoneResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        /// <summary>
        /// Remove duplicates in resource path which can happen if the exact return values from the CreateHostedZone
        /// operation are used.
        /// </summary>
        /// <param name="request"></param>
        protected override void ProcessRequestHandlers(IRequest request)
        {
            base.ProcessRequestHandlers(request);


            if (request.ResourcePath.Contains("/hostedzone//hostedzone/"))
            {
                request.ResourcePath = request.ResourcePath.Replace("/hostedzone//hostedzone/", "/hostedzone/");
            }
            if (request.ResourcePath.Contains("/change//change/"))
            {
                request.ResourcePath = request.ResourcePath.Replace("/change//change/", "/change/");
            }

            if (request.ResourcePath.EndsWith("/rrset/"))
            {
                string content = System.Text.UTF8Encoding.UTF8.GetString(request.Content);
                if (content.Contains("<HostedZoneId>/hostedzone/"))
                {
                    content = content.Replace("<HostedZoneId>/hostedzone/", "<HostedZoneId>");
                }
                request.Content = System.Text.UTF8Encoding.UTF8.GetBytes(content);
            }
        }

    }
}
    
