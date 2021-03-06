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
    /// ScannerParams
    /// </summary>
    [DataContract]
    public partial class ScannerParams :  IEquatable<ScannerParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerParams" /> class.
        /// </summary>
        /// <param name="instrumentList">Contains list of instruments for which scanner can be ran.</param>
        /// <param name="locationTree">Contains list of instruments for which scanner can be ran.</param>
        /// <param name="filterList">Contains list of filters supported for the scanner.</param>
        /// <param name="scanTypeList">Contains list of scan types for which scanner can be ran.</param>
        public ScannerParams(Object instrumentList = default(Object), Object locationTree = default(Object), List<Object> filterList = default(List<Object>), Object scanTypeList = default(Object))
        {
            this.InstrumentList = instrumentList;
            this.LocationTree = locationTree;
            this.FilterList = filterList;
            this.ScanTypeList = scanTypeList;
        }
        
        /// <summary>
        /// Contains list of instruments for which scanner can be ran
        /// </summary>
        /// <value>Contains list of instruments for which scanner can be ran</value>
        [DataMember(Name="InstrumentList", EmitDefaultValue=false)]
        public Object InstrumentList { get; set; }

        /// <summary>
        /// Contains list of instruments for which scanner can be ran
        /// </summary>
        /// <value>Contains list of instruments for which scanner can be ran</value>
        [DataMember(Name="LocationTree", EmitDefaultValue=false)]
        public Object LocationTree { get; set; }

        /// <summary>
        /// Contains list of filters supported for the scanner
        /// </summary>
        /// <value>Contains list of filters supported for the scanner</value>
        [DataMember(Name="FilterList", EmitDefaultValue=false)]
        public List<Object> FilterList { get; set; }

        /// <summary>
        /// Contains list of scan types for which scanner can be ran
        /// </summary>
        /// <value>Contains list of scan types for which scanner can be ran</value>
        [DataMember(Name="ScanTypeList", EmitDefaultValue=false)]
        public Object ScanTypeList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScannerParams {\n");
            sb.Append("  InstrumentList: ").Append(InstrumentList).Append("\n");
            sb.Append("  LocationTree: ").Append(LocationTree).Append("\n");
            sb.Append("  FilterList: ").Append(FilterList).Append("\n");
            sb.Append("  ScanTypeList: ").Append(ScanTypeList).Append("\n");
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
            return this.Equals(input as ScannerParams);
        }

        /// <summary>
        /// Returns true if ScannerParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ScannerParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScannerParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentList == input.InstrumentList ||
                    (this.InstrumentList != null &&
                    this.InstrumentList.Equals(input.InstrumentList))
                ) && 
                (
                    this.LocationTree == input.LocationTree ||
                    (this.LocationTree != null &&
                    this.LocationTree.Equals(input.LocationTree))
                ) && 
                (
                    this.FilterList == input.FilterList ||
                    this.FilterList != null &&
                    this.FilterList.SequenceEqual(input.FilterList)
                ) && 
                (
                    this.ScanTypeList == input.ScanTypeList ||
                    (this.ScanTypeList != null &&
                    this.ScanTypeList.Equals(input.ScanTypeList))
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
                if (this.InstrumentList != null)
                    hashCode = hashCode * 59 + this.InstrumentList.GetHashCode();
                if (this.LocationTree != null)
                    hashCode = hashCode * 59 + this.LocationTree.GetHashCode();
                if (this.FilterList != null)
                    hashCode = hashCode * 59 + this.FilterList.GetHashCode();
                if (this.ScanTypeList != null)
                    hashCode = hashCode * 59 + this.ScanTypeList.GetHashCode();
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
