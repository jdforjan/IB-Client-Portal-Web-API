/* 
 * Client Portal Web API
 *
 * Client Portal Web API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// AuthStatus
    /// </summary>
    [DataContract]
    public partial class AuthStatus :  IEquatable<AuthStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthStatus" /> class.
        /// </summary>
        /// <param name="authenticated">Brokerage session is authenticated.</param>
        /// <param name="connected">Connected to backend.</param>
        /// <param name="competing">Brokerage session is competing, e.g. user is logged in to IBKR Mobile, WebTrader, TWS or other trading platforms..</param>
        /// <param name="fail">Authentication failed, why..</param>
        /// <param name="message">System messages that may affect trading.</param>
        /// <param name="prompts">Prompt messages that may affect trading or the account.</param>
        public AuthStatus(bool? authenticated = default(bool?), bool? connected = default(bool?), bool? competing = default(bool?), string fail = default(string), string message = default(string), List<string> prompts = default(List<string>))
        {
            this.Authenticated = authenticated;
            this.Connected = connected;
            this.Competing = competing;
            this.Fail = fail;
            this.Message = message;
            this.Prompts = prompts;
        }
        
        /// <summary>
        /// Brokerage session is authenticated
        /// </summary>
        /// <value>Brokerage session is authenticated</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }

        /// <summary>
        /// Connected to backend
        /// </summary>
        /// <value>Connected to backend</value>
        [DataMember(Name="connected", EmitDefaultValue=false)]
        public bool? Connected { get; set; }

        /// <summary>
        /// Brokerage session is competing, e.g. user is logged in to IBKR Mobile, WebTrader, TWS or other trading platforms.
        /// </summary>
        /// <value>Brokerage session is competing, e.g. user is logged in to IBKR Mobile, WebTrader, TWS or other trading platforms.</value>
        [DataMember(Name="competing", EmitDefaultValue=false)]
        public bool? Competing { get; set; }

        /// <summary>
        /// Authentication failed, why.
        /// </summary>
        /// <value>Authentication failed, why.</value>
        [DataMember(Name="fail", EmitDefaultValue=false)]
        public string Fail { get; set; }

        /// <summary>
        /// System messages that may affect trading
        /// </summary>
        /// <value>System messages that may affect trading</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Prompt messages that may affect trading or the account
        /// </summary>
        /// <value>Prompt messages that may affect trading or the account</value>
        [DataMember(Name="prompts", EmitDefaultValue=false)]
        public List<string> Prompts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthStatus {\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  Competing: ").Append(Competing).Append("\n");
            sb.Append("  Fail: ").Append(Fail).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Prompts: ").Append(Prompts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthStatus);
        }

        /// <summary>
        /// Returns true if AuthStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authenticated == input.Authenticated ||
                    (this.Authenticated != null &&
                    this.Authenticated.Equals(input.Authenticated))
                ) && 
                (
                    this.Connected == input.Connected ||
                    (this.Connected != null &&
                    this.Connected.Equals(input.Connected))
                ) && 
                (
                    this.Competing == input.Competing ||
                    (this.Competing != null &&
                    this.Competing.Equals(input.Competing))
                ) && 
                (
                    this.Fail == input.Fail ||
                    (this.Fail != null &&
                    this.Fail.Equals(input.Fail))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Prompts == input.Prompts ||
                    this.Prompts != null &&
                    this.Prompts.SequenceEqual(input.Prompts)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Authenticated != null)
                    hashCode = hashCode * 59 + this.Authenticated.GetHashCode();
                if (this.Connected != null)
                    hashCode = hashCode * 59 + this.Connected.GetHashCode();
                if (this.Competing != null)
                    hashCode = hashCode * 59 + this.Competing.GetHashCode();
                if (this.Fail != null)
                    hashCode = hashCode * 59 + this.Fail.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Prompts != null)
                    hashCode = hashCode * 59 + this.Prompts.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
