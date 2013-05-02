﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace ImmutableObjectGraph.Tests {
	using System.Diagnostics;
	using System.Linq;
	using ImmutableObjectGraph;
	
	public interface IFileSystemEntry {
		System.String PathSegment { get; }
	}
	
	public abstract partial class FileSystemEntry : IFileSystemEntry {
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String pathSegment;
	
		/// <summary>Initializes a new instance of the FileSystemEntry class.</summary>
		protected FileSystemEntry()
		{
		}
	
		/// <summary>Initializes a new instance of the FileSystemEntry class.</summary>
		protected FileSystemEntry(
			System.String pathSegment)
			: base()
		{
			this.pathSegment = pathSegment;
		}
	
		public System.String PathSegment {
			get { return this.pathSegment; }
		}
		
		/// <summary>Returns a new instance with the PathSegment property set to the specified value.</summary>
		public FileSystemEntry WithPathSegment(System.String value) {
			if (value == this.PathSegment) {
				return this;
			}
		
			return this.With(pathSegment: value);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public abstract FileSystemEntry With(
			ImmutableObjectGraph.Optional<System.String> pathSegment = default(ImmutableObjectGraph.Optional<System.String>));
		
		public virtual FileSystemFile ToFileSystemFile(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>> attributes = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>>)) {
			FileSystemFile that = this as FileSystemFile;
			if (that != null && this.GetType().IsEquivalentTo(typeof(FileSystemFile))) {
				if ((!attributes.IsDefined || attributes.Value == that.Attributes)) {
					return that;
				}
			}
		
			return FileSystemFile.Create(
				pathSegment: this.PathSegment,
				attributes: attributes);
		}
		
		public virtual FileSystemDirectory ToFileSystemDirectory(
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>>)) {
			FileSystemDirectory that = this as FileSystemDirectory;
			if (that != null && this.GetType().IsEquivalentTo(typeof(FileSystemDirectory))) {
				if ((!children.IsDefined || children.Value == that.Children)) {
					return that;
				}
			}
		
			return FileSystemDirectory.Create(
				pathSegment: this.PathSegment,
				children: children);
		}
		
		public Builder ToBuilder() {
			return new Builder(this);
		}
		
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private FileSystemEntry immutable;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String pathSegment;
		
			internal Builder(FileSystemEntry immutable) {
				this.immutable = immutable;
		
				this.pathSegment = immutable.PathSegment;
			}
		
			public System.String PathSegment {
				get {
					return this.pathSegment;
				}
		
				set {
					this.pathSegment = value;
				}
			}
		
			public FileSystemEntry ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.PathSegment));
			}
		}
	}
	
	public abstract partial class FileSystemEntryRed : IFileSystemEntry {
		private readonly FileSystemEntry greenNode;
	
		private readonly FileSystemEntry parent;
	
		protected FileSystemEntryRed(FileSystemEntry greenNode, FileSystemEntry parent) {
			this.greenNode = greenNode;
			this.parent = parent;
		}
	
		/// <summary>Gets the parent of this object in the hierarchy.</summary>
		public FileSystemEntry GreenNode {
			get { return this.greenNode; }
		}
	
		public System.String PathSegment {
			get { return this.GreenNode.PathSegment; }
		}
		
		/// <summary>Returns a new instance with the PathSegment property set to the specified value.</summary>
		public FileSystemEntryRed WithPathSegment(System.String value) {
			throw new System.NotImplementedException();
		}
	}
	
	public interface IFileSystemFile : IFileSystemEntry {
		System.Collections.Immutable.ImmutableHashSet<System.String> Attributes { get; }
	}
	
	public partial class FileSystemFile : FileSystemEntry, IFileSystemFile {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly FileSystemFile DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableHashSet<System.String> attributes;
	
		/// <summary>Initializes a new instance of the FileSystemFile class.</summary>
		protected FileSystemFile()
		{
		}
	
		/// <summary>Initializes a new instance of the FileSystemFile class.</summary>
		protected FileSystemFile(
			System.String pathSegment,
			System.Collections.Immutable.ImmutableHashSet<System.String> attributes)
			: base(
				pathSegment: pathSegment)
		{
			this.attributes = attributes;
			this.Validate();
		}
	
		public static FileSystemFile Create(
			System.String pathSegment,
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>> attributes = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>>)) {
			return DefaultInstance.With(
				pathSegment: pathSegment,
				attributes: attributes.GetValueOrDefault(DefaultInstance.Attributes));
		}
	
		public System.Collections.Immutable.ImmutableHashSet<System.String> Attributes {
			get { return this.attributes; }
		}
		
		/// <summary>Returns a new instance with the PathSegment property set to the specified value.</summary>
		public new FileSystemFile WithPathSegment(System.String value) {
			return (FileSystemFile)base.WithPathSegment(value);
		}
		
		/// <summary>Returns a new instance with the Attributes property set to the specified value.</summary>
		public FileSystemFile WithAttributes(System.Collections.Immutable.ImmutableHashSet<System.String> value) {
			if (value == this.Attributes) {
				return this;
			}
		
			return this.With(attributes: value);
		}
		
		/// <summary>Replaces the elements of the Attributes collection with the specified collection.</summary>
		public FileSystemFile WithAttributes(params System.String[] values) {
			return this.With(attributes: this.Attributes.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Attributes collection with the specified collection.</summary>
		public FileSystemFile WithAttributes(System.Collections.Generic.IEnumerable<System.String> values) {
			return this.With(attributes: this.Attributes.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Attributes collection.</summary>
		public FileSystemFile AddAttributes(System.Collections.Generic.IEnumerable<System.String> values) {
			return this.With(attributes: this.Attributes.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Attributes collection.</summary>
		public FileSystemFile AddAttributes(params System.String[] values) {
			return this.With(attributes: this.Attributes.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Attributes collection.</summary>
		public FileSystemFile AddAttributes(System.String value) {
			return this.With(attributes: this.Attributes.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Attributes collection.</summary>
		public FileSystemFile RemoveAttributes(System.Collections.Generic.IEnumerable<System.String> values) {
			return this.With(attributes: this.Attributes.RemoveRange(values));
		}
		
		/// <summary>Removes the specified elements from the Attributes collection.</summary>
		public FileSystemFile RemoveAttributes(params System.String[] values) {
			return this.With(attributes: this.Attributes.RemoveRange(values));
		}
		
		/// <summary>Removes the specified element from the Attributes collection.</summary>
		public FileSystemFile RemoveAttributes(System.String value) {
			return this.With(attributes: this.Attributes.Remove(value));
		}
		
		/// <summary>Clears all elements from the Attributes collection.</summary>
		public FileSystemFile RemoveAttributes() {
			return this.With(attributes: this.Attributes.Clear());
		}
		
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public override FileSystemEntry With(
			ImmutableObjectGraph.Optional<System.String> pathSegment = default(ImmutableObjectGraph.Optional<System.String>)) {
			return this.With(
				pathSegment: pathSegment,
				attributes: default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>>));
		}
		
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual FileSystemFile With(
			ImmutableObjectGraph.Optional<System.String> pathSegment = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>> attributes = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>>)) {
			if (
				(pathSegment.IsDefined && pathSegment.Value != this.PathSegment) || 
				(attributes.IsDefined && attributes.Value != this.Attributes)) {
				return new FileSystemFile(
					pathSegment: pathSegment.GetValueOrDefault(this.PathSegment),
					attributes: attributes.GetValueOrDefault(this.Attributes));
			} else {
				return this;
			}
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated FileSystemFile whose fields are initialized with default values.</summary>
		private static FileSystemFile GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new FileSystemFile(
				template.PathSegment, 
				template.Attributes);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String PathSegment { get; set; }
	
			internal System.Collections.Immutable.ImmutableHashSet<System.String> Attributes { get; set; }
		}
		
		public new Builder ToBuilder() {
			return new Builder(this);
		}
		
		public new partial class Builder : FileSystemEntry.Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private FileSystemFile immutable;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableHashSet<System.String>.Builder> attributes;
		
			internal Builder(FileSystemFile immutable) : base(immutable) {
				this.immutable = immutable;
		
			}
		
			public System.Collections.Immutable.ImmutableHashSet<System.String>.Builder Attributes {
				get {
					if (!this.attributes.IsDefined) {
						this.attributes = this.immutable.attributes != null ? this.immutable.attributes.ToBuilder() : null;
					}
		
					return this.attributes.Value;
				}
		
				set {
					this.attributes = value;
				}
			}
		
			public new FileSystemFile ToImmutable() {
				var attributes = this.attributes.IsDefined ? (this.attributes.Value != null ? this.attributes.Value.ToImmutable() : null) : this.immutable.Attributes;
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.PathSegment),
					ImmutableObjectGraph.Optional.For(attributes));
			}
		}
	}
	
	public partial class FileSystemFileRed : FileSystemEntryRed, IFileSystemFile {
		protected FileSystemFileRed(FileSystemFile greenNode, FileSystemFile parent) : base(greenNode, parent) {
		}
	
		/// <summary>Gets the parent of this object in the hierarchy.</summary>
		public new FileSystemFile GreenNode {
			get { return (FileSystemFile)base.GreenNode; }
		}
	
		public System.Collections.Immutable.ImmutableHashSet<System.String> Attributes {
			get { return this.GreenNode.Attributes; }
		}
		
		/// <summary>Returns a new instance with the PathSegment property set to the specified value.</summary>
		public new FileSystemFileRed WithPathSegment(System.String value) {
			return (FileSystemFileRed)base.WithPathSegment(value);
		}
		
		/// <summary>Returns a new instance with the Attributes property set to the specified value.</summary>
		public FileSystemFileRed WithAttributes(System.Collections.Immutable.ImmutableHashSet<System.String> value) {
			throw new System.NotImplementedException();
		}
	}
	
	public interface IFileSystemDirectory : IFileSystemEntry {
		System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry> Children { get; }
	}
	
	public partial class FileSystemDirectory : FileSystemEntry, IFileSystemDirectory, System.Collections.Generic.IEnumerable<FileSystemEntry> {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly FileSystemDirectory DefaultInstance = GetDefaultTemplate();
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry> children;
	
		/// <summary>Initializes a new instance of the FileSystemDirectory class.</summary>
		protected FileSystemDirectory()
		{
		}
	
		/// <summary>Initializes a new instance of the FileSystemDirectory class.</summary>
		protected FileSystemDirectory(
			System.String pathSegment,
			System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry> children)
			: base(
				pathSegment: pathSegment)
		{
			this.children = children;
			this.Validate();
		}
	
		public static FileSystemDirectory Create(
			System.String pathSegment,
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>>)) {
			return DefaultInstance.With(
				pathSegment: pathSegment,
				children: children.GetValueOrDefault(DefaultInstance.Children));
		}
	
		public System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry> Children {
			get { return this.children; }
		}
		
		/// <summary>Returns a new instance with the PathSegment property set to the specified value.</summary>
		public new FileSystemDirectory WithPathSegment(System.String value) {
			return (FileSystemDirectory)base.WithPathSegment(value);
		}
		
		/// <summary>Returns a new instance with the Children property set to the specified value.</summary>
		public FileSystemDirectory WithChildren(System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry> value) {
			if (value == this.Children) {
				return this;
			}
		
			return this.With(children: value);
		}
		
		/// <summary>Replaces the elements of the Children collection with the specified collection.</summary>
		public FileSystemDirectory WithChildren(params FileSystemEntry[] values) {
			return this.With(children: this.Children.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Children collection with the specified collection.</summary>
		public FileSystemDirectory WithChildren(System.Collections.Generic.IEnumerable<FileSystemEntry> values) {
			return this.With(children: this.Children.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Children collection.</summary>
		public FileSystemDirectory AddChildren(System.Collections.Generic.IEnumerable<FileSystemEntry> values) {
			return this.With(children: this.Children.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Children collection.</summary>
		public FileSystemDirectory AddChildren(params FileSystemEntry[] values) {
			return this.With(children: this.Children.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Children collection.</summary>
		public FileSystemDirectory AddChildren(FileSystemEntry value) {
			return this.With(children: this.Children.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Children collection.</summary>
		public FileSystemDirectory RemoveChildren(System.Collections.Generic.IEnumerable<FileSystemEntry> values) {
			return this.With(children: this.Children.RemoveRange(values));
		}
		
		/// <summary>Removes the specified elements from the Children collection.</summary>
		public FileSystemDirectory RemoveChildren(params FileSystemEntry[] values) {
			return this.With(children: this.Children.RemoveRange(values));
		}
		
		/// <summary>Removes the specified element from the Children collection.</summary>
		public FileSystemDirectory RemoveChildren(FileSystemEntry value) {
			return this.With(children: this.Children.Remove(value));
		}
		
		/// <summary>Clears all elements from the Children collection.</summary>
		public FileSystemDirectory RemoveChildren() {
			return this.With(children: this.Children.Clear());
		}
		
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public override FileSystemEntry With(
			ImmutableObjectGraph.Optional<System.String> pathSegment = default(ImmutableObjectGraph.Optional<System.String>)) {
			return this.With(
				pathSegment: pathSegment,
				children: default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>>));
		}
		
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public virtual FileSystemDirectory With(
			ImmutableObjectGraph.Optional<System.String> pathSegment = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>> children = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>>)) {
			if (
				(pathSegment.IsDefined && pathSegment.Value != this.PathSegment) || 
				(children.IsDefined && children.Value != this.Children)) {
				return new FileSystemDirectory(
					pathSegment: pathSegment.GetValueOrDefault(this.PathSegment),
					children: children.GetValueOrDefault(this.Children));
			} else {
				return this;
			}
		}
	
	
		public System.Collections.Generic.IEnumerator<FileSystemEntry> GetEnumerator() {
			return this.children.GetEnumerator();
		}
	
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return this.children.GetEnumerator();
		}
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated FileSystemDirectory whose fields are initialized with default values.</summary>
		private static FileSystemDirectory GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new FileSystemDirectory(
				template.PathSegment, 
				template.Children);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String PathSegment { get; set; }
	
			internal System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry> Children { get; set; }
		}
		
		public FileSystemDirectory ReplaceDescendent(FileSystemEntry current, FileSystemEntry replacement) {
			// TODO: fix this horribly inefficient algorithm.
			var newChildren = this.Children.Replace(current, replacement);
			if (this.Children != newChildren) {
				return this.WithChildren(newChildren);
			}
			
			foreach (var child in this.OfType<FileSystemDirectory>())
			{
				var newChild = child.ReplaceDescendent(current, replacement);
				if (newChild != child) {
					newChildren = this.Children.Replace(child, newChild);
					return this.WithChildren(newChildren);
				}
			}
				
			return this;
		}
		
		public new Builder ToBuilder() {
			return new Builder(this);
		}
		
		public new partial class Builder : FileSystemEntry.Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private FileSystemDirectory immutable;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>.Builder> children;
		
			internal Builder(FileSystemDirectory immutable) : base(immutable) {
				this.immutable = immutable;
		
			}
		
			public System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry>.Builder Children {
				get {
					if (!this.children.IsDefined) {
						this.children = this.immutable.children != null ? this.immutable.children.ToBuilder() : null;
					}
		
					return this.children.Value;
				}
		
				set {
					this.children = value;
				}
			}
		
			public new FileSystemDirectory ToImmutable() {
				var children = this.children.IsDefined ? (this.children.Value != null ? this.children.Value.ToImmutable() : null) : this.immutable.Children;
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.PathSegment),
					ImmutableObjectGraph.Optional.For(children));
			}
		}
	}
	
	public partial class FileSystemDirectoryRed : FileSystemEntryRed, IFileSystemDirectory, System.Collections.Generic.IEnumerable<FileSystemEntryRed> {
		protected FileSystemDirectoryRed(FileSystemDirectory greenNode, FileSystemDirectory parent) : base(greenNode, parent) {
		}
	
		/// <summary>Gets the parent of this object in the hierarchy.</summary>
		public new FileSystemDirectory GreenNode {
			get { return (FileSystemDirectory)base.GreenNode; }
		}
	
		public System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry> Children {
			get { return this.GreenNode.Children; }
		}
		
		/// <summary>Returns a new instance with the PathSegment property set to the specified value.</summary>
		public new FileSystemDirectoryRed WithPathSegment(System.String value) {
			return (FileSystemDirectoryRed)base.WithPathSegment(value);
		}
		
		/// <summary>Returns a new instance with the Children property set to the specified value.</summary>
		public FileSystemDirectoryRed WithChildren(System.Collections.Immutable.ImmutableSortedSet<FileSystemEntry> value) {
			throw new System.NotImplementedException();
		}
	}
}


