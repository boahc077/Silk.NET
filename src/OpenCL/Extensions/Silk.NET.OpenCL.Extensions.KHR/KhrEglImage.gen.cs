// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_egl_image")]
    public unsafe partial class KhrEglImage : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_egl_image";
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (MemFlags, EglImageProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (MemFlags, EglImageProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (MemFlags, EglImageProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (CLEnum, KHR) are deprecated in favour of the \"grouped\" enums (MemFlags, EglImageProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateFromEGLImageKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateFromEglimage([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint egldisplay, [Flow(FlowDirection.In)] nint eglimage, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] in nint properties, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueAcquireEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueAcquireEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] nint* mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReleaseEGLObjectsKHR", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReleaseEglobjects([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] uint num_objects, [Flow(FlowDirection.In)] in nint mem_objects, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        public KhrEglImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

