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

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Guid("7f027b22-1515-4e85-aa0d-026486580576")]
    [NativeName("Name", "ID3D12VideoEncodeCommandList3")]
    public unsafe partial struct ID3D12VideoEncodeCommandList3
    {
        public static readonly Guid Guid = new("7f027b22-1515-4e85-aa0d-026486580576");

        public static implicit operator ID3D12VideoEncodeCommandList2(ID3D12VideoEncodeCommandList3 val)
            => Unsafe.As<ID3D12VideoEncodeCommandList3, ID3D12VideoEncodeCommandList2>(ref val);

        public static implicit operator ID3D12VideoEncodeCommandList1(ID3D12VideoEncodeCommandList3 val)
            => Unsafe.As<ID3D12VideoEncodeCommandList3, ID3D12VideoEncodeCommandList1>(ref val);

        public static implicit operator ID3D12VideoEncodeCommandList(ID3D12VideoEncodeCommandList3 val)
            => Unsafe.As<ID3D12VideoEncodeCommandList3, ID3D12VideoEncodeCommandList>(ref val);

        public static implicit operator ID3D12CommandList(ID3D12VideoEncodeCommandList3 val)
            => Unsafe.As<ID3D12VideoEncodeCommandList3, ID3D12CommandList>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12VideoEncodeCommandList3 val)
            => Unsafe.As<ID3D12VideoEncodeCommandList3, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12VideoEncodeCommandList3 val)
            => Unsafe.As<ID3D12VideoEncodeCommandList3, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoEncodeCommandList3 val)
            => Unsafe.As<ID3D12VideoEncodeCommandList3, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoEncodeCommandList3
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, char*, int>)LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, char*, int>)LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CommandListType GetType()
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CommandListType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, CommandListType>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, int>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset(ref ID3D12CommandAllocator pAllocator)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState()
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, void>)LpVtbl[11])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriers);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegion);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, void>)LpVtbl[20])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EstimateMotion(ID3D12VideoMotionEstimator* pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, VideoMotionEstimatorInput* pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)LpVtbl[21])(@this, pMotionEstimator, pOutputArguments, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EstimateMotion(ID3D12VideoMotionEstimator* pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, ref VideoMotionEstimatorInput pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)LpVtbl[21])(@this, pMotionEstimator, pOutputArguments, pInputArgumentsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EstimateMotion(ID3D12VideoMotionEstimator* pMotionEstimator, ref VideoMotionEstimatorOutput pOutputArguments, VideoMotionEstimatorInput* pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)LpVtbl[21])(@this, pMotionEstimator, pOutputArgumentsPtr, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EstimateMotion(ID3D12VideoMotionEstimator* pMotionEstimator, ref VideoMotionEstimatorOutput pOutputArguments, ref VideoMotionEstimatorInput pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)LpVtbl[21])(@this, pMotionEstimator, pOutputArgumentsPtr, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EstimateMotion(ref ID3D12VideoMotionEstimator pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, VideoMotionEstimatorInput* pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArguments, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EstimateMotion(ref ID3D12VideoMotionEstimator pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, ref VideoMotionEstimatorInput pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
            {
                fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArguments, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EstimateMotion(ref ID3D12VideoMotionEstimator pMotionEstimator, ref VideoMotionEstimatorOutput pOutputArguments, VideoMotionEstimatorInput* pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
            {
                fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArgumentsPtr, pInputArguments);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EstimateMotion(ref ID3D12VideoMotionEstimator pMotionEstimator, ref VideoMotionEstimatorOutput pOutputArguments, ref VideoMotionEstimatorInput pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
            {
                fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveMotionVectorHeap(ResolveVideoMotionVectorHeapOutput* pOutputArguments, ResolveVideoMotionVectorHeapInput* pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)LpVtbl[22])(@this, pOutputArguments, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveMotionVectorHeap(ResolveVideoMotionVectorHeapOutput* pOutputArguments, ref ResolveVideoMotionVectorHeapInput pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResolveVideoMotionVectorHeapInput* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)LpVtbl[22])(@this, pOutputArguments, pInputArgumentsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveMotionVectorHeap(ref ResolveVideoMotionVectorHeapOutput pOutputArguments, ResolveVideoMotionVectorHeapInput* pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResolveVideoMotionVectorHeapOutput* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)LpVtbl[22])(@this, pOutputArgumentsPtr, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveMotionVectorHeap(ref ResolveVideoMotionVectorHeapOutput pOutputArguments, ref ResolveVideoMotionVectorHeapInput pInputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResolveVideoMotionVectorHeapOutput* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (ResolveVideoMotionVectorHeapInput* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)LpVtbl[22])(@this, pOutputArgumentsPtr, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[23])(@this, Count, pParams, pModes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[23])(@this, Count, pParams, pModesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[23])(@this, Count, pParamsPtr, pModes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[23])(@this, Count, pParamsPtr, pModesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSession);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetProtectedResourceSession(ref ID3D12ProtectedResourceSession pProtectedResourceSession)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSessionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pInitializationParametersPtr = &pInitializationParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParametersPtr, InitializationParametersSizeInBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParameters, InitializationParametersSizeInBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void InitializeExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                fixed (void* pInitializationParametersPtr = &pInitializationParameters)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParametersPtr, InitializationParametersSizeInBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                fixed (void* pExecutionParametersPtr = &pExecutionParameters)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, VideoEncoderEncodeframeInputArguments* pInputArguments, VideoEncoderEncodeframeOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoder, pHeap, pInputArguments, pOutputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, VideoEncoderEncodeframeInputArguments* pInputArguments, ref VideoEncoderEncodeframeOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoder, pHeap, pInputArguments, pOutputArgumentsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, ref VideoEncoderEncodeframeInputArguments pInputArguments, VideoEncoderEncodeframeOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoder, pHeap, pInputArgumentsPtr, pOutputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ID3D12VideoEncoder* pEncoder, ID3D12VideoEncoderHeap* pHeap, ref VideoEncoderEncodeframeInputArguments pInputArguments, ref VideoEncoderEncodeframeOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
            {
                fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoder, pHeap, pInputArgumentsPtr, pOutputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ID3D12VideoEncoder* pEncoder, ref ID3D12VideoEncoderHeap pHeap, VideoEncoderEncodeframeInputArguments* pInputArguments, VideoEncoderEncodeframeOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoder, pHeapPtr, pInputArguments, pOutputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ID3D12VideoEncoder* pEncoder, ref ID3D12VideoEncoderHeap pHeap, VideoEncoderEncodeframeInputArguments* pInputArguments, ref VideoEncoderEncodeframeOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
            {
                fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoder, pHeapPtr, pInputArguments, pOutputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ID3D12VideoEncoder* pEncoder, ref ID3D12VideoEncoderHeap pHeap, ref VideoEncoderEncodeframeInputArguments pInputArguments, VideoEncoderEncodeframeOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
            {
                fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoder, pHeapPtr, pInputArgumentsPtr, pOutputArguments);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ID3D12VideoEncoder* pEncoder, ref ID3D12VideoEncoderHeap pHeap, ref VideoEncoderEncodeframeInputArguments pInputArguments, ref VideoEncoderEncodeframeOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
            {
                fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoder, pHeapPtr, pInputArgumentsPtr, pOutputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ref ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap* pHeap, VideoEncoderEncodeframeInputArguments* pInputArguments, VideoEncoderEncodeframeOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoderPtr, pHeap, pInputArguments, pOutputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ref ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap* pHeap, VideoEncoderEncodeframeInputArguments* pInputArguments, ref VideoEncoderEncodeframeOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoderPtr, pHeap, pInputArguments, pOutputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ref ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap* pHeap, ref VideoEncoderEncodeframeInputArguments pInputArguments, VideoEncoderEncodeframeOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoderPtr, pHeap, pInputArgumentsPtr, pOutputArguments);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ref ID3D12VideoEncoder pEncoder, ID3D12VideoEncoderHeap* pHeap, ref VideoEncoderEncodeframeInputArguments pInputArguments, ref VideoEncoderEncodeframeOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoderPtr, pHeap, pInputArgumentsPtr, pOutputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ref ID3D12VideoEncoder pEncoder, ref ID3D12VideoEncoderHeap pHeap, VideoEncoderEncodeframeInputArguments* pInputArguments, VideoEncoderEncodeframeOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoderPtr, pHeapPtr, pInputArguments, pOutputArguments);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ref ID3D12VideoEncoder pEncoder, ref ID3D12VideoEncoderHeap pHeap, VideoEncoderEncodeframeInputArguments* pInputArguments, ref VideoEncoderEncodeframeOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
                {
                    fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoderPtr, pHeapPtr, pInputArguments, pOutputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncodeFrame(ref ID3D12VideoEncoder pEncoder, ref ID3D12VideoEncoderHeap pHeap, ref VideoEncoderEncodeframeInputArguments pInputArguments, VideoEncoderEncodeframeOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
                {
                    fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoderPtr, pHeapPtr, pInputArgumentsPtr, pOutputArguments);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EncodeFrame(ref ID3D12VideoEncoder pEncoder, ref ID3D12VideoEncoderHeap pHeap, ref VideoEncoderEncodeframeInputArguments pInputArguments, ref VideoEncoderEncodeframeOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (ID3D12VideoEncoderHeap* pHeapPtr = &pHeap)
                {
                    fixed (VideoEncoderEncodeframeInputArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        fixed (VideoEncoderEncodeframeOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, ID3D12VideoEncoder*, ID3D12VideoEncoderHeap*, VideoEncoderEncodeframeInputArguments*, VideoEncoderEncodeframeOutputArguments*, void>)LpVtbl[27])(@this, pEncoderPtr, pHeapPtr, pInputArgumentsPtr, pOutputArgumentsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveEncoderOutputMetadata(VideoEncoderResolveMetadataInputArguments* pInputArguments, VideoEncoderResolveMetadataOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, VideoEncoderResolveMetadataInputArguments*, VideoEncoderResolveMetadataOutputArguments*, void>)LpVtbl[28])(@this, pInputArguments, pOutputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveEncoderOutputMetadata(VideoEncoderResolveMetadataInputArguments* pInputArguments, ref VideoEncoderResolveMetadataOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoEncoderResolveMetadataOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, VideoEncoderResolveMetadataInputArguments*, VideoEncoderResolveMetadataOutputArguments*, void>)LpVtbl[28])(@this, pInputArguments, pOutputArgumentsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveEncoderOutputMetadata(ref VideoEncoderResolveMetadataInputArguments pInputArguments, VideoEncoderResolveMetadataOutputArguments* pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoEncoderResolveMetadataInputArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, VideoEncoderResolveMetadataInputArguments*, VideoEncoderResolveMetadataOutputArguments*, void>)LpVtbl[28])(@this, pInputArgumentsPtr, pOutputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveEncoderOutputMetadata(ref VideoEncoderResolveMetadataInputArguments pInputArguments, ref VideoEncoderResolveMetadataOutputArguments pOutputArguments)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoEncoderResolveMetadataInputArguments* pInputArgumentsPtr = &pInputArguments)
            {
                fixed (VideoEncoderResolveMetadataOutputArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, VideoEncoderResolveMetadataInputArguments*, VideoEncoderResolveMetadataOutputArguments*, void>)LpVtbl[28])(@this, pInputArgumentsPtr, pOutputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Barrier(uint NumBarrierGroups, BarrierGroup* pBarrierGroups)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, BarrierGroup*, void>)LpVtbl[29])(@this, NumBarrierGroups, pBarrierGroups);
        }

        /// <summary>To be documented.</summary>
        public readonly void Barrier(uint NumBarrierGroups, ref BarrierGroup pBarrierGroups)
        {
            var @this = (ID3D12VideoEncodeCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BarrierGroup* pBarrierGroupsPtr = &pBarrierGroups)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList3*, uint, BarrierGroup*, void>)LpVtbl[29])(@this, NumBarrierGroups, pBarrierGroupsPtr);
            }
        }

    }
}
