﻿namespace AutoBUS.Sockets
{
    /// <summary>
    /// How to handle exceptions when raised.
    /// </summary>
    public enum ExceptionHandlerResponse
    {
        /// <summary>
        /// Silence the exception.
        /// </summary>
        Silence,

        /// <summary>
        /// Rethrow exception.
        /// </summary>
        Rethrow,

        /// <summary>
        /// Close socket without throwing exception.
        /// </summary>
        CloseSocket,
    }

    /// <summary>
    /// Class to handle different events from sockets.
    /// </summary>
    public interface IEventsListener
    {
        /// <summary>
        /// Called when data is sent.
        /// </summary>
        void OnDataSend(SocketClient socket, byte[] data);

        /// <summary>
        /// Called when data is read.
        /// </summary>
        void OnDataRead(SocketClient socket, byte[] data);

        /// <summary>
        /// Called when a whole framed message is sent.
        /// </summary>
        void OnMessageSend(SocketClient socket, byte[] data);

        /// <summary>
        /// Called when a whole framed message is read.
        /// </summary>
        void OnMessageRead(SocketClient socket, byte[] data);

        /// <summary>
        /// Called when a new connection is created.
        /// </summary>
        void OnNewConnection(SocketClient socket);

        /// <summary>
        /// Called when a connection is closed.
        /// </summary>
        void OnConnectionClosed(SocketClient socket);

        /// <summary>
        /// Called on exceptions.
        /// </summary>
        /// <returns>How to handle the exception.</returns>
        ExceptionHandlerResponse OnException(SocketClient socket, System.Exception exception);
    }
}