using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace BasicAttributes
{
	public class Common
	{
		private string _Group = string.Empty;
		[Category( "Common" )]
		[Description( "Group of components that this one belongs to." )]
		public string Group {
			get {
				return _Group;
			}
			set {
				_Group = value;
			}
		}

		private string _Name = string.Empty;
		[Category( "Common" )]
		[Description( "Component name." )]
		public string Name {
			get {
				return _Name;
			}
			set {
				_Name = value;
			}
		}

		private Color _BorderColor = SystemColors.InactiveBorder;
		[Category( "Common" )]
		[Description( "Border color of the component." )]
		public Color BorderColor {
			get {
				return _BorderColor;
			}
			set {
				_BorderColor = value;
			}
		}

		private Color _BackgroundColor = SystemColors.Control;
		[Category( "Common" )]
		[Description( "Background color of the component." )]
		public Color BackgroundColor {
			get {
				return _BackgroundColor;
			}
			set {
				_BackgroundColor = value;
			}
		}

		private bool _Visibility = true;
		[Category( "Common" )]
		[Description( @"Visibility of the component.
						Parameter will be overridden by Visible Condition." )]
		public bool Visibility {
			get {
				return _Visibility;
			}
			set {
				_Visibility = value;
			}
		}
	}
}