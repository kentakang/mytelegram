﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Invoke the specified query using the specified API <a href="https://corefork.telegram.org/api/invoking#layers">layer</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 AUTH_BYTES_INVALID The provided authorization is invalid.
/// 400 CDN_METHOD_INVALID You can't call this method in a CDN DC.
/// 403 CHAT_WRITE_FORBIDDEN You can't write in this chat.
/// 400 CONNECTION_API_ID_INVALID The provided API id is invalid.
/// 406 INVITE_HASH_EXPIRED The invite link has expired.
/// See <a href="https://corefork.telegram.org/method/invokeWithLayer" />
///</summary>
[TlObject(0xda9b0d0d)]
public sealed class RequestInvokeWithLayer : IRequest<IObject>
{
    public uint ConstructorId => 0xda9b0d0d;
    ///<summary>
    /// The layer to use
    ///</summary>
    public int Layer { get; set; }

    ///<summary>
    /// The query
    ///</summary>
    public IObject Query { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Layer);
        writer.Write(Query);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Layer = reader.ReadInt32();
        Query = reader.Read<IObject>();
    }
}
