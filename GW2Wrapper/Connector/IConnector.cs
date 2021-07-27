namespace GW2Wrapper.Connector
{
    /// <summary>
    /// Interface of the api connector
    /// </summary>
    interface IConnector
    {
        /// <summary>
        /// Calls an endpoint of the api
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns>
        /// Content in the endpoint
        /// </returns>
        string Call(string endpoint);
    }
}
