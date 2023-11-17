﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;

///<summary>
/// Check if the <a href="https://corefork.telegram.org/api/srp">2FA recovery code</a> sent using <a href="https://corefork.telegram.org/method/auth.requestPasswordRecovery">auth.requestPasswordRecovery</a> is valid, before passing it to <a href="https://corefork.telegram.org/method/auth.recoverPassword">auth.recoverPassword</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 PASSWORD_RECOVERY_EXPIRED The recovery code has expired.
/// See <a href="https://corefork.telegram.org/method/auth.checkRecoveryPassword" />
///</summary>
[TlObject(0xd36bf79)]
public sealed class RequestCheckRecoveryPassword : IRequest<IBool>
{
    public uint ConstructorId => 0xd36bf79;
    ///<summary>
    /// Code received via email
    ///</summary>
    public string Code { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Code);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Code = reader.ReadString();
    }
}