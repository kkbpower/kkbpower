package md5b37efa53a8f92041a7ca611ca77e65bd;


public class PhotoViewAttacher_FlingRunnable
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.lang.Runnable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler:Java.Lang.IRunnableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("XamarinAndroidPhotoViewer.PhotoViewAttacher+FlingRunnable, TestImageZoom.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PhotoViewAttacher_FlingRunnable.class, __md_methods);
	}


	public PhotoViewAttacher_FlingRunnable () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PhotoViewAttacher_FlingRunnable.class)
			mono.android.TypeManager.Activate ("XamarinAndroidPhotoViewer.PhotoViewAttacher+FlingRunnable, TestImageZoom.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public PhotoViewAttacher_FlingRunnable (md5b37efa53a8f92041a7ca611ca77e65bd.PhotoViewAttacher p0, android.content.Context p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == PhotoViewAttacher_FlingRunnable.class)
			mono.android.TypeManager.Activate ("XamarinAndroidPhotoViewer.PhotoViewAttacher+FlingRunnable, TestImageZoom.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "XamarinAndroidPhotoViewer.PhotoViewAttacher, TestImageZoom.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
