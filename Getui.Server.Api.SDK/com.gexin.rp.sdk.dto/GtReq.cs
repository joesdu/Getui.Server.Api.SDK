using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000004 RID: 4
    [DebuggerNonUserCode]
	public static class GtReq
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000020A2 File Offset: 0x000002A2
		public static void RegisterAllExtensions(ExtensionRegistry registry)
		{
		}

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x0600000F RID: 15 RVA: 0x000020A4 File Offset: 0x000002A4
        public static FileDescriptor Descriptor { get; private set; }

        // Token: 0x06000010 RID: 16 RVA: 0x000020AC File Offset: 0x000002AC
        static GtReq()
		{
			byte[] descriptorData = Convert.FromBase64String("CgtHdFJlcS5wcm90bxIUY29tLmdleGluLnJwLnNkay5kdG8iSAoGR3RBdXRoEgwKBHNpZ24YASACKAkSDgoGYXBwa2V5GAIgAigJEhEKCXRpbWVzdGFtcBgDIAIoAxINCgVzZXFJZBgEIAEoCSLrAQoMR3RBdXRoUmVzdWx0EgwKBGNvZGUYASACKAUSFwoPcmVkaXJlY3RBZGRyZXNzGAIgASgJEg0KBXNlcUlkGAMgASgJEgwKBGluZm8YBCABKAkSDQoFYXBwaWQYBSADKAkihwEKEEd0QXV0aFJlc3VsdENvZGUSDQoJc3VjY2Vzc2VkEAASEQoNZmFpbGVkX25vU2lnbhABEhMKD2ZhaWxlZF9ub0FwcGtleRACEhYKEmZhaWxlZF9ub1RpbWVzdGFtcBADEhYKEmZhaWxlZF9BdXRoSWxsZWdhbBAEEgwKCHJlZGlyZWN0EAUiLwoLUmVxU2Vydkxpc3QSDQoFc2VxSWQYASABKAkSEQoJdGltZXN0YW1wGAMgAigDInwKEVJlcVNlcnZMaXN0UmVzdWx0EgwKBGNvZGUYASACKAUSDAoEaG9zdBgCIAMoCRINCgVzZXFJZBgDIAEoCSI8ChVSZXFTZXJ2SG9zdFJlc3VsdENvZGUSDQoJc3VjY2Vzc2VkEAASCgoGZmFpbGVkEAESCAoEYnVzeRACIkMKDlB1c2hMaXN0UmVzdWx0EjEKB3Jlc3VsdHMYASADKAsyIC5jb20uZ2V4aW4ucnAuc2RrLmR0by5QdXNoUmVzdWx0IugCCgpQdXNoUmVzdWx0EjwKBnJlc3VsdBgBIAIoDjIsLmNvbS5nZXhpbi5ycC5zZGsuZHRvLlB1c2hSZXN1bHQuRVB1c2hSZXN1bHQSDgoGdGFza0lkGAIgAigJEhEKCW1lc3NhZ2VJZBgDIAIoCRINCgVzZXFJZBgEIAIoCRIOCgZ0YXJnZXQYBSACKAkSDAoEaW5mbxgGIAEoCRIPCgd0cmFjZUlkGAcgASgJEg8KB2JhdGNoSWQYCCABKAkiqQEKC0VQdXNoUmVzdWx0EhQKEHN1Y2Nlc3NlZF9vbmxpbmUQABIVChFzdWNjZXNzZWRfb2ZmbGluZRABEhQKEHN1Y2Nlc3NlZF9pZ25vcmUQAhIKCgZmYWlsZWQQAxIICgRidXN5EAQSFgoSc3VjY2Vzc19zdGFydEJhdGNoEAUSFAoQc3VjY2Vzc19lbmRCYXRjaBAGEhMKD3N1Y2Nlc3NlZF9hc3luYxAHIoQBChNQdXNoT1NTaW5nbGVNZXNzYWdlEg0KBXNlcUlkGAEgAigJEjAKB21lc3NhZ2UYAiACKAsyHy5jb20uZ2V4aW4ucnAuc2RrLmR0by5PU01lc3NhZ2USLAoGdGFyZ2V0GAMgAigLMhwuY29tLmdleGluLnJwLnNkay5kdG8uVGFyZ2V0IpkBChRQdXNoTU1QU2luZ2xlTWVzc2FnZRINCgVzZXFJZBgBIAIoCRIxCgdtZXNzYWdlGAIgAigLMiAuY29tLmdleGluLnJwLnNkay5kdG8uTU1QTWVzc2FnZRIsCgZ0YXJnZXQYAyACKAsyHC5jb20uZ2V4aW4ucnAuc2RrLmR0by5UYXJnZXQSEQoJcmVxdWVzdElkGAQgASgJIoEBChlQdXNoTU1QU2luZ2xlQmF0Y2hNZXNzYWdlEg8KB2JhdGNoSWQYASACKAkSPQoJYmF0Y2hJdGVtGAIgAygLMiouY29tLmdleGluLnJwLnNkay5kdG8uUHVzaE1NUFNpbmdsZU1lc3NhZ2USFAoGaXNTeW5jGAMgASgIOgR0cnVlIoABChFTdGFydE1NUEJhdGNoVGFzaxIxCgdtZXNzYWdlGAEgAigLMiAuY29tLmdleGluLnJwLnNkay5kdG8uTU1QTWVzc2FnZRISCgZleHBpcmUYAiACKAM6AjcyEg0KBXNlcUlkGAMgASgJEhUKDXRhc2tHcm91cE5hbWUYBCABKAkiWAoQU3RhcnRPU0JhdGNoVGFzaxIwCgdtZXNzYWdlGAEgAigLMh8uY29tLmdleGluLnJwLnNkay5kdG8uT1NNZXNzYWdlEhIKBmV4cGlyZRgCIAIoAzoCNzIiXwoSU2luZ2xlQmF0Y2hSZXF1ZXN0Eg8KB2JhdGNoSWQYASACKAkSOAoJYmF0Y2hJdGVtGAIgAygLMiUuY29tLmdleGluLnJwLnNkay5kdG8uU2luZ2xlQmF0Y2hJdGVtIi4KD1NpbmdsZUJhdGNoSXRlbRINCgVzZXFJZBgBIAIoBRIMCgRkYXRhGAIgAigJIl8KD1B1c2hMaXN0TWVzc2FnZRINCgVzZXFJZBgBIAIoCRIOCgZ0YXNrSWQYAiACKAkSLQoHdGFyZ2V0cxgDIAMoCzIcLmNvbS5nZXhpbi5ycC5zZGsuZHRvLlRhcmdldCItCgxFbmRCYXRjaFRhc2sSDgoGdGFza0lkGAEgAigJEg0KBXNlcUlkGAIgASgJIk0KDVN0b3BCYXRjaFRhc2sSDgoGdGFza0lkGAEgAigJEg4KBmFwcGtleRgCIAIoCRINCgVhcHBJZBgDIAEoCRINCgVzZXFJZBgEIAEoCSJCChNTdG9wQmF0Y2hUYXNrUmVzdWx0Eg4KBnJlc3VsdBgBIAIoCBIMCgRpbmZvGAIgASgJEg0KBXNlcUlkGAMgASgJIpUBChFQdXNoTU1QQXBwTWVzc2FnZRIxCgdtZXNzYWdlGAEgAigLMiAuY29tLmdleGluLnJwLnNkay5kdG8uTU1QTWVzc2FnZRIRCglhcHBJZExpc3QYAiADKAkSFQoNcGhvbmVUeXBlTGlzdBgDIAMoCRIUCgxwcm92aW5jZUxpc3QYBCADKAkSDQoFc2VxSWQYBSABKAkiuwEKDFNlcnZlck5vdGlmeRI7CgR0eXBlGAEgAigOMi0uY29tLmdleGluLnJwLnNkay5kdG8uU2VydmVyTm90aWZ5Lk5vdGlmeVR5cGUSDAoEaW5mbxgCIAEoCRIRCglleHRyYWRhdGEYAyABKAwSDQoFc2VxSWQYBCABKAkiPgoKTm90aWZ5VHlwZRIKCgZub3JtYWwQABIVChFzZXJ2ZXJMaXN0Q2hhbmdlZBABEg0KCWV4Y2VwdGlvbhACIjEKElNlcnZlck5vdGlmeVJlc3VsdBINCgVzZXFJZBgBIAIoCRIMCgRpbmZvGAIgASgJIsABCglPU01lc3NhZ2USEQoJaXNPZmZsaW5lGAIgAigIEhwKEW9mZmxpbmVFeHBpcmVUaW1lGAMgAigDOgExEjYKC3RyYW5zcGFyZW50GAQgASgLMiEuY29tLmdleGluLnJwLnNkay5kdG8uVHJhbnNwYXJlbnQSEQoJZXh0cmFEYXRhGAUgASgJEg8KB21zZ1R5cGUYBiABKAUSFAoMbXNnVHJhY2VGbGFnGAcgASgFEhAKCHByaW9yaXR5GAggASgFIukBCgpNTVBNZXNzYWdlEjYKC3RyYW5zcGFyZW50GAIgASgLMiEuY29tLmdleGluLnJwLnNkay5kdG8uVHJhbnNwYXJlbnQSEQoJZXh0cmFEYXRhGAMgASgJEg8KB21zZ1R5cGUYBCABKAUSFAoMbXNnVHJhY2VGbGFnGAUgASgFEhgKEG1zZ09mZmxpbmVFeHBpcmUYBiABKAMSFwoJaXNPZmZsaW5lGAcgASgIOgR0cnVlEhAKCHByaW9yaXR5GAggASgFEg4KBmNkblVybBgJIAEoCRIUCgZpc1N5bmMYCiABKAg6BHRydWUiwQIKC1RyYW5zcGFyZW50EgoKAmlkGAEgAigJEg4KBmFjdGlvbhgCIAIoCRIOCgZ0YXNrSWQYAyACKAkSDgoGYXBwS2V5GAQgAigJEg0KBWFwcElkGAUgAigJEhEKCW1lc3NhZ2VJZBgGIAIoCRIwCghwdXNoSW5mbxgHIAEoCzIeLmNvbS5nZXhpbi5ycC5zZGsuZHRvLlB1c2hJbmZvEjYKC2FjdGlvbkNoYWluGAggAygLMiEuY29tLmdleGluLnJwLnNkay5kdG8uQWN0aW9uQ2hhaW4SEQoJY29uZGl0aW9uGAkgAygJEhIKCnRlbXBsYXRlSWQYCiABKAUSEwoLdGFza0dyb3VwSWQYCyABKAkSLgoHc21zSW5mbxgMIAEoCzIdLmNvbS5nZXhpbi5ycC5zZGsuZHRvLlNtc0luZm8i1wIKCFB1c2hJbmZvEg8KB21lc3NhZ2UYASABKAkSEQoJYWN0aW9uS2V5GAIgASgJEg0KBXNvdW5kGAMgASgJEg0KBWJhZGdlGAQgASgJEg8KB3BheWxvYWQYBSABKAkSDgoGbG9jS2V5GAYgASgJEg8KB2xvY0FyZ3MYByABKAkSFAoMYWN0aW9uTG9jS2V5GAggASgJEhMKC2xhdW5jaEltYWdlGAkgASgJEhgKEGNvbnRlbnRBdmFpbGFibGUYCiABKAUSEgoKaW52YWxpZEFQThgLIAEoCBIPCgdhcG5Kc29uGAwgASgJEhIKCmludmFsaWRNUE4YDSABKAgSDgoGbXBuWG1sGA4gASgJEhMKC3ZhbGlkTm90aWZ5GA8gASgIEjQKCm5vdGlmeUluZm8YECABKAsyIC5jb20uZ2V4aW4ucnAuc2RrLmR0by5Ob3RpZnlJbmZvItgBCgpOb3RpZnlJbmZvEg0KBXRpdGxlGAEgAigJEg8KB2NvbnRlbnQYAiACKAkSDwoHcGF5bG9hZBgDIAEoCRIOCgZpbnRlbnQYBCABKAkSCwoDdXJsGAUgASgJEj0KBHR5cGUYBiABKA4yJS5jb20uZ2V4aW4ucnAuc2RrLmR0by5Ob3RpZnlJbmZvLlR5cGU6CF9wYXlsb2FkEhAKCG5vdGlmeUlkGAcgASgJIisKBFR5cGUSDAoIX3BheWxvYWQQABILCgdfaW50ZW50EAESCAoEX3VybBACIpoKCgtBY3Rpb25DaGFpbhIQCghhY3Rpb25JZBgBIAIoBRI0CgR0eXBlGAIgAigOMiYuY29tLmdleGluLnJwLnNkay5kdG8uQWN0aW9uQ2hhaW4uVHlwZRIMCgRuZXh0GAMgASgFEgwKBGxvZ28YZCABKAkSDwoHbG9nb1VSTBhlIAEoCRINCgV0aXRsZRhmIAEoCRIMCgR0ZXh0GGcgASgJEhEKCWNsZWFyYWJsZRhoIAEoCBIMCgRyaW5nGGkgASgIEgwKBGJ1enoYaiABKAgSEQoJYmFubmVyVVJMGGsgASgJEgsKA2ltZxh4IAEoCRItCgdidXR0b25zGHkgAygLMhwuY29tLmdleGluLnJwLnNkay5kdG8uQnV0dG9uEg4KBWFwcGlkGIwBIAEoCRI3CgxhcHBzdGFydHVwaWQYjQEgASgLMiAuY29tLmdleGluLnJwLnNkay5kdG8uQXBwU3RhcnRVcBISCglhdXRvc3RhcnQYjgEgASgIEhUKDGZhaWxlZEFjdGlvbhiPASABKAUSDAoDdXJsGKABIAEoCRIQCgd3aXRoY2lkGKEBIAEoCRIeCg5pc193aXRobmV0dHlwZRiiASABKAg6BWZhbHNlEhAKB2FkZHJlc3MYtAEgASgJEhAKB2NvbnRlbnQYtQEgASgJEgsKAmN0GLYBIAEoAxIuCgRmbGFnGLcBIAEoDjIfLmNvbS5nZXhpbi5ycC5zZGsuZHRvLlNNU1N0YXR1cxIYCg9zdWNjZXNzZWRBY3Rpb24YyAEgASgFEhoKEXVuaW5zdGFsbGVkQWN0aW9uGMkBIAEoBRINCgRuYW1lGNwBIAEoCRIUCgthdXRvSW5zdGFsbBjfASABKAgSGQoQd2lmaUF1dG9kb3dubG9hZBjhASABKAgSFgoNZm9yY2VEb3dubG9hZBjiASABKAgSFQoMc2hvd1Byb2dyZXNzGOMBIAEoCBINCgRwb3N0GPEBIAEoCRIQCgdoZWFkZXJzGPIBIAEoCRISCglncm91cGFibGUYhAIgASgIEhEKCG1tc1RpdGxlGJgCIAEoCRIPCgZtbXNVUkwYmQIgASgJEhAKB3ByZWxvYWQYrAIgASgIEg8KBnRhc2tpZBjAAiABKAkSEQoIZHVyYXRpb24Y1AIgASgDEg0KBGRhdGUY6AIgASgJEg4KBXN0eXBlGPwCIAEoCRIwCgVmaWVsZBj9AiADKAsyIC5jb20uZ2V4aW4ucnAuc2RrLmR0by5Jbm5lckZpbGVkIuACCgRUeXBlEggKBEdvdG8QABIQCgxub3RpZmljYXRpb24QARIJCgVwb3B1cBACEgwKCHN0YXJ0YXBwEAMSDAoIc3RhcnR3ZWIQBBIMCghzbXNpbmJveBAFEgwKCGNoZWNrYXBwEAYSBwoDZW9hEAcSDwoLYXBwZG93bmxvYWQQCBIMCghzdGFydHNtcxAJEg0KCWh0dHBwcm94eRAKEg0KCXNtc2luYm94MhALEg0KCW1tc2luYm94MhAMEgwKCHBvcHVwd2ViEA0SCAoEZGlhbBAOEhEKDXJlcG9ydGJpbmRhcHAQDxIWChJyZXBvcnRhZGRwaG9uZWluZm8QEBIRCg1yZXBvcnRhcHBsaXN0EBESEQoNdGVybWluYXRldGFzaxASEg0KCXJlcG9ydGFwcBATEg0KCWVuYWJsZWxvZxAUEg4KCmRpc2FibGVsb2cQFRINCgl1cGxvYWRsb2cQFiKgAQoKSW5uZXJGaWxlZBILCgNrZXkYASACKAkSCwoDdmFsGAIgAigJEjMKBHR5cGUYAyACKA4yJS5jb20uZ2V4aW4ucnAuc2RrLmR0by5Jbm5lckZpbGVkLlR5cGUiQwoEVHlwZRIHCgNzdHIQABIJCgVpbnQzMhABEgkKBWludDY0EAISCAoEZmxvYRADEggKBGRvdWIQBBIICgRib29sEAUiOgoKQXBwU3RhcnRVcBIPCgdhbmRyb2lkGAEgASgJEg4KBnN5bWJpYRgCIAEoCRILCgNpb3MYAyABKAkiJAoGQnV0dG9uEgwKBHRleHQYASABKAkSDAoEbmV4dBgCIAEoBSI4CgZUYXJnZXQSDQoFYXBwSWQYASACKAkSEAoIY2xpZW50SWQYAiACKAkSDQoFYWxpYXMYAyABKAkiLQoPU21zQ29udGVudEVudHJ5EgsKA2tleRgBIAIoCRINCgV2YWx1ZRgCIAIoCSLEAQoHU21zSW5mbxIVCg1zbXNUZW1wbGF0ZUlkGAEgAigJEjkKCnNtc0NvbnRlbnQYAiADKAsyJS5jb20uZ2V4aW4ucnAuc2RrLmR0by5TbXNDb250ZW50RW50cnkSFwoPb2ZmbGluZVNlbmR0aW1lGAMgAigDEhcKD3Ntc1NlbmREdXJhdGlvbhgEIAEoAxIZCgpzbXNDaGVja2VkGAUgASgIOgVmYWxzZRIaChJzbXNDaGVja2VkRXJyb3JNc2cYBiABKAkqjQMKBUNtZElEEg0KCUdUSEVBUkRCVBAAEgoKBkdUQVVUSBABEhEKDUdUQVVUSF9SRVNVTFQQAhIPCgtSRVFTRVJWSE9TVBADEhUKEVJFUVNFUlZIT1NUUkVTVUxUEAQSDgoKUFVTSFJFU1VMVBAFEhcKE1BVU0hPU1NJTkdMRU1FU1NBR0UQBhIYChRQVVNITU1QU0lOR0xFTUVTU0FHRRAHEhUKEVNUQVJUTU1QQkFUQ0hUQVNLEAgSFAoQU1RBUlRPU0JBVENIVEFTSxAJEhMKD1BVU0hMSVNUTUVTU0FHRRAKEhAKDEVOREJBVENIVEFTSxALEhUKEVBVU0hNTVBBUFBNRVNTQUdFEAwSEAoMU0VSVkVSTk9USUZZEA0SEgoOUFVTSExJU1RSRVNVTFQQDhIWChJTRVJWRVJOT1RJRllSRVNVTFQQDxIRCg1TVE9QQkFUQ0hUQVNLEBASFwoTU1RPUEJBVENIVEFTS1JFU1VMVBAREhYKElBVU0hNTVBTSU5HTEVCQVRDSBASKiEKCVNNU1N0YXR1cxIKCgZ1bnJlYWQQABIICgRyZWFkEAFCAkgB");
			FileDescriptor.InternalDescriptorAssigner descriptorAssigner = delegate (FileDescriptor root)
			{
                Descriptor = root;
                internal__static_com_gexin_rp_sdk_dto_GtAuth__Descriptor = Descriptor.MessageTypes[0];
                internal__static_com_gexin_rp_sdk_dto_GtAuth__FieldAccessorTable = new FieldAccessorTable<GtAuth, GtAuth.Builder>(internal__static_com_gexin_rp_sdk_dto_GtAuth__Descriptor, new string[]
				{
					"Sign",
					"Appkey",
					"Timestamp",
					"SeqId"
				});
                internal__static_com_gexin_rp_sdk_dto_GtAuthResult__Descriptor = Descriptor.MessageTypes[1];
                internal__static_com_gexin_rp_sdk_dto_GtAuthResult__FieldAccessorTable = new FieldAccessorTable<GtAuthResult, GtAuthResult.Builder>(internal__static_com_gexin_rp_sdk_dto_GtAuthResult__Descriptor, new string[]
				{
					"Code",
					"RedirectAddress",
					"SeqId",
					"Info",
					"Appid"
				});
                internal__static_com_gexin_rp_sdk_dto_ReqServList__Descriptor = Descriptor.MessageTypes[2];
                internal__static_com_gexin_rp_sdk_dto_ReqServList__FieldAccessorTable = new FieldAccessorTable<ReqServList, ReqServList.Builder>(internal__static_com_gexin_rp_sdk_dto_ReqServList__Descriptor, new string[]
				{
					"SeqId",
					"Timestamp"
				});
                internal__static_com_gexin_rp_sdk_dto_ReqServListResult__Descriptor = Descriptor.MessageTypes[3];
                internal__static_com_gexin_rp_sdk_dto_ReqServListResult__FieldAccessorTable = new FieldAccessorTable<ReqServListResult, ReqServListResult.Builder>(internal__static_com_gexin_rp_sdk_dto_ReqServListResult__Descriptor, new string[]
				{
					"Code",
					"Host",
					"SeqId"
				});
                internal__static_com_gexin_rp_sdk_dto_PushListResult__Descriptor = Descriptor.MessageTypes[4];
                internal__static_com_gexin_rp_sdk_dto_PushListResult__FieldAccessorTable = new FieldAccessorTable<PushListResult, PushListResult.Builder>(internal__static_com_gexin_rp_sdk_dto_PushListResult__Descriptor, new string[]
				{
					"Results"
				});
                internal__static_com_gexin_rp_sdk_dto_PushResult__Descriptor = Descriptor.MessageTypes[5];
                internal__static_com_gexin_rp_sdk_dto_PushResult__FieldAccessorTable = new FieldAccessorTable<PushResult, PushResult.Builder>(internal__static_com_gexin_rp_sdk_dto_PushResult__Descriptor, new string[]
				{
					"Result",
					"TaskId",
					"MessageId",
					"SeqId",
					"Target",
					"Info",
					"TraceId",
					"BatchId"
				});
                internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__Descriptor = Descriptor.MessageTypes[6];
                internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__FieldAccessorTable = new FieldAccessorTable<PushOSSingleMessage, PushOSSingleMessage.Builder>(internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__Descriptor, new string[]
				{
					"SeqId",
					"Message",
					"Target"
				});
                internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__Descriptor = Descriptor.MessageTypes[7];
                internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__FieldAccessorTable = new FieldAccessorTable<PushMMPSingleMessage, PushMMPSingleMessage.Builder>(internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__Descriptor, new string[]
				{
					"SeqId",
					"Message",
					"Target",
					"RequestId"
				});
                internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__Descriptor = Descriptor.MessageTypes[8];
                internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__FieldAccessorTable = new FieldAccessorTable<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder>(internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__Descriptor, new string[]
				{
					"BatchId",
					"BatchItem",
					"IsSync"
				});
                internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__Descriptor = Descriptor.MessageTypes[9];
                internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__FieldAccessorTable = new FieldAccessorTable<StartMMPBatchTask, StartMMPBatchTask.Builder>(internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__Descriptor, new string[]
				{
					"Message",
					"Expire",
					"SeqId",
					"TaskGroupName"
				});
                internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__Descriptor = Descriptor.MessageTypes[10];
                internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__FieldAccessorTable = new FieldAccessorTable<StartOSBatchTask, StartOSBatchTask.Builder>(internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__Descriptor, new string[]
				{
					"Message",
					"Expire"
				});
                internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__Descriptor = Descriptor.MessageTypes[11];
                internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__FieldAccessorTable = new FieldAccessorTable<SingleBatchRequest, SingleBatchRequest.Builder>(internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__Descriptor, new string[]
				{
					"BatchId",
					"BatchItem"
				});
                internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__Descriptor = Descriptor.MessageTypes[12];
                internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__FieldAccessorTable = new FieldAccessorTable<SingleBatchItem, SingleBatchItem.Builder>(internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__Descriptor, new string[]
				{
					"SeqId",
					"Data"
				});
                internal__static_com_gexin_rp_sdk_dto_PushListMessage__Descriptor = Descriptor.MessageTypes[13];
                internal__static_com_gexin_rp_sdk_dto_PushListMessage__FieldAccessorTable = new FieldAccessorTable<PushListMessage, PushListMessage.Builder>(internal__static_com_gexin_rp_sdk_dto_PushListMessage__Descriptor, new string[]
				{
					"SeqId",
					"TaskId",
					"Targets"
				});
                internal__static_com_gexin_rp_sdk_dto_EndBatchTask__Descriptor = Descriptor.MessageTypes[14];
                internal__static_com_gexin_rp_sdk_dto_EndBatchTask__FieldAccessorTable = new FieldAccessorTable<EndBatchTask, EndBatchTask.Builder>(internal__static_com_gexin_rp_sdk_dto_EndBatchTask__Descriptor, new string[]
				{
					"TaskId",
					"SeqId"
				});
                internal__static_com_gexin_rp_sdk_dto_StopBatchTask__Descriptor = Descriptor.MessageTypes[15];
                internal__static_com_gexin_rp_sdk_dto_StopBatchTask__FieldAccessorTable = new FieldAccessorTable<StopBatchTask, StopBatchTask.Builder>(internal__static_com_gexin_rp_sdk_dto_StopBatchTask__Descriptor, new string[]
				{
					"TaskId",
					"Appkey",
					"AppId",
					"SeqId"
				});
                internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__Descriptor = Descriptor.MessageTypes[16];
                internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__FieldAccessorTable = new FieldAccessorTable<StopBatchTaskResult, StopBatchTaskResult.Builder>(internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__Descriptor, new string[]
				{
					"Result",
					"Info",
					"SeqId"
				});
                internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__Descriptor = Descriptor.MessageTypes[17];
                internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__FieldAccessorTable = new FieldAccessorTable<PushMMPAppMessage, PushMMPAppMessage.Builder>(internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__Descriptor, new string[]
				{
					"Message",
					"AppIdList",
					"PhoneTypeList",
					"ProvinceList",
					"SeqId"
				});
                internal__static_com_gexin_rp_sdk_dto_ServerNotify__Descriptor = Descriptor.MessageTypes[18];
                internal__static_com_gexin_rp_sdk_dto_ServerNotify__FieldAccessorTable = new FieldAccessorTable<ServerNotify, ServerNotify.Builder>(internal__static_com_gexin_rp_sdk_dto_ServerNotify__Descriptor, new string[]
				{
					"Type",
					"Info",
					"Extradata",
					"SeqId"
				});
                internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__Descriptor = Descriptor.MessageTypes[19];
                internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__FieldAccessorTable = new FieldAccessorTable<ServerNotifyResult, ServerNotifyResult.Builder>(internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__Descriptor, new string[]
				{
					"SeqId",
					"Info"
				});
                internal__static_com_gexin_rp_sdk_dto_OSMessage__Descriptor = Descriptor.MessageTypes[20];
                internal__static_com_gexin_rp_sdk_dto_OSMessage__FieldAccessorTable = new FieldAccessorTable<OSMessage, OSMessage.Builder>(internal__static_com_gexin_rp_sdk_dto_OSMessage__Descriptor, new string[]
				{
					"IsOffline",
					"OfflineExpireTime",
					"Transparent",
					"ExtraData",
					"MsgType",
					"MsgTraceFlag",
					"Priority"
				});
                internal__static_com_gexin_rp_sdk_dto_MMPMessage__Descriptor = Descriptor.MessageTypes[21];
                internal__static_com_gexin_rp_sdk_dto_MMPMessage__FieldAccessorTable = new FieldAccessorTable<MMPMessage, MMPMessage.Builder>(internal__static_com_gexin_rp_sdk_dto_MMPMessage__Descriptor, new string[]
				{
					"Transparent",
					"ExtraData",
					"MsgType",
					"MsgTraceFlag",
					"MsgOfflineExpire",
					"IsOffline",
					"Priority",
					"CdnUrl",
					"IsSync"
				});
                internal__static_com_gexin_rp_sdk_dto_Transparent__Descriptor = Descriptor.MessageTypes[22];
                internal__static_com_gexin_rp_sdk_dto_Transparent__FieldAccessorTable = new FieldAccessorTable<Transparent, Transparent.Builder>(internal__static_com_gexin_rp_sdk_dto_Transparent__Descriptor, new string[]
				{
					"Id",
					"Action",
					"TaskId",
					"AppKey",
					"AppId",
					"MessageId",
					"PushInfo",
					"ActionChain",
					"Condition",
					"TemplateId",
					"TaskGroupId",
					"SmsInfo"
				});
                internal__static_com_gexin_rp_sdk_dto_PushInfo__Descriptor = Descriptor.MessageTypes[23];
                internal__static_com_gexin_rp_sdk_dto_PushInfo__FieldAccessorTable = new FieldAccessorTable<PushInfo, PushInfo.Builder>(internal__static_com_gexin_rp_sdk_dto_PushInfo__Descriptor, new string[]
				{
					"Message",
					"ActionKey",
					"Sound",
					"Badge",
					"Payload",
					"LocKey",
					"LocArgs",
					"ActionLocKey",
					"LaunchImage",
					"ContentAvailable",
					"InvalidAPN",
					"ApnJson",
					"InvalidMPN",
					"MpnXml",
					"ValidNotify",
					"NotifyInfo"
				});
                internal__static_com_gexin_rp_sdk_dto_NotifyInfo__Descriptor = Descriptor.MessageTypes[24];
                internal__static_com_gexin_rp_sdk_dto_NotifyInfo__FieldAccessorTable = new FieldAccessorTable<NotifyInfo, NotifyInfo.Builder>(internal__static_com_gexin_rp_sdk_dto_NotifyInfo__Descriptor, new string[]
				{
					"Title",
					"Content",
					"Payload",
					"Intent",
					"Url",
					"Type",
					"NotifyId"
				});
                internal__static_com_gexin_rp_sdk_dto_ActionChain__Descriptor = Descriptor.MessageTypes[25];
                internal__static_com_gexin_rp_sdk_dto_ActionChain__FieldAccessorTable = new FieldAccessorTable<ActionChain, ActionChain.Builder>(internal__static_com_gexin_rp_sdk_dto_ActionChain__Descriptor, new string[]
				{
					"ActionId",
					"Type",
					"Next",
					"Logo",
					"LogoURL",
					"Title",
					"Text",
					"Clearable",
					"Ring",
					"Buzz",
					"BannerURL",
					"Img",
					"Buttons",
					"Appid",
					"Appstartupid",
					"Autostart",
					"FailedAction",
					"Url",
					"Withcid",
					"IsWithnettype",
					"Address",
					"Content",
					"Ct",
					"Flag",
					"SuccessedAction",
					"UninstalledAction",
					"Name",
					"AutoInstall",
					"WifiAutodownload",
					"ForceDownload",
					"ShowProgress",
					"Post",
					"Headers",
					"Groupable",
					"MmsTitle",
					"MmsURL",
					"Preload",
					"Taskid",
					"Duration",
					"Date",
					"Stype",
					"Field"
				});
                internal__static_com_gexin_rp_sdk_dto_InnerFiled__Descriptor = Descriptor.MessageTypes[26];
                internal__static_com_gexin_rp_sdk_dto_InnerFiled__FieldAccessorTable = new FieldAccessorTable<InnerFiled, InnerFiled.Builder>(internal__static_com_gexin_rp_sdk_dto_InnerFiled__Descriptor, new string[]
				{
					"Key",
					"Val",
					"Type"
				});
                internal__static_com_gexin_rp_sdk_dto_AppStartUp__Descriptor = Descriptor.MessageTypes[27];
                internal__static_com_gexin_rp_sdk_dto_AppStartUp__FieldAccessorTable = new FieldAccessorTable<AppStartUp, AppStartUp.Builder>(internal__static_com_gexin_rp_sdk_dto_AppStartUp__Descriptor, new string[]
				{
					"Android",
					"Symbia",
					"Ios"
				});
                internal__static_com_gexin_rp_sdk_dto_Button__Descriptor = Descriptor.MessageTypes[28];
                internal__static_com_gexin_rp_sdk_dto_Button__FieldAccessorTable = new FieldAccessorTable<Button, Button.Builder>(internal__static_com_gexin_rp_sdk_dto_Button__Descriptor, new string[]
				{
					"Text",
					"Next"
				});
                internal__static_com_gexin_rp_sdk_dto_Target__Descriptor = Descriptor.MessageTypes[29];
                internal__static_com_gexin_rp_sdk_dto_Target__FieldAccessorTable = new FieldAccessorTable<Target, Target.Builder>(internal__static_com_gexin_rp_sdk_dto_Target__Descriptor, new string[]
				{
					"AppId",
					"ClientId",
					"Alias"
				});
                internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__Descriptor = Descriptor.MessageTypes[30];
                internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__FieldAccessorTable = new FieldAccessorTable<SmsContentEntry, SmsContentEntry.Builder>(internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__Descriptor, new string[]
				{
					"Key",
					"Value"
				});
                internal__static_com_gexin_rp_sdk_dto_SmsInfo__Descriptor = Descriptor.MessageTypes[31];
                internal__static_com_gexin_rp_sdk_dto_SmsInfo__FieldAccessorTable = new FieldAccessorTable<SmsInfo, SmsInfo.Builder>(internal__static_com_gexin_rp_sdk_dto_SmsInfo__Descriptor, new string[]
				{
					"SmsTemplateId",
					"SmsContent",
					"OfflineSendtime",
					"SmsSendDuration",
					"SmsChecked",
					"SmsCheckedErrorMsg"
				});
				return null;
			};
			FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData, new FileDescriptor[0], descriptorAssigner);
		}

		// Token: 0x04000005 RID: 5
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_GtAuth__Descriptor;

		// Token: 0x04000006 RID: 6
		internal static FieldAccessorTable<GtAuth, GtAuth.Builder> internal__static_com_gexin_rp_sdk_dto_GtAuth__FieldAccessorTable;

		// Token: 0x04000007 RID: 7
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_GtAuthResult__Descriptor;

		// Token: 0x04000008 RID: 8
		internal static FieldAccessorTable<GtAuthResult, GtAuthResult.Builder> internal__static_com_gexin_rp_sdk_dto_GtAuthResult__FieldAccessorTable;

		// Token: 0x04000009 RID: 9
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_ReqServList__Descriptor;

		// Token: 0x0400000A RID: 10
		internal static FieldAccessorTable<ReqServList, ReqServList.Builder> internal__static_com_gexin_rp_sdk_dto_ReqServList__FieldAccessorTable;

		// Token: 0x0400000B RID: 11
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_ReqServListResult__Descriptor;

		// Token: 0x0400000C RID: 12
		internal static FieldAccessorTable<ReqServListResult, ReqServListResult.Builder> internal__static_com_gexin_rp_sdk_dto_ReqServListResult__FieldAccessorTable;

		// Token: 0x0400000D RID: 13
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_PushListResult__Descriptor;

		// Token: 0x0400000E RID: 14
		internal static FieldAccessorTable<PushListResult, PushListResult.Builder> internal__static_com_gexin_rp_sdk_dto_PushListResult__FieldAccessorTable;

		// Token: 0x0400000F RID: 15
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_PushResult__Descriptor;

		// Token: 0x04000010 RID: 16
		internal static FieldAccessorTable<PushResult, PushResult.Builder> internal__static_com_gexin_rp_sdk_dto_PushResult__FieldAccessorTable;

		// Token: 0x04000011 RID: 17
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__Descriptor;

		// Token: 0x04000012 RID: 18
		internal static FieldAccessorTable<PushOSSingleMessage, PushOSSingleMessage.Builder> internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__FieldAccessorTable;

		// Token: 0x04000013 RID: 19
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__Descriptor;

		// Token: 0x04000014 RID: 20
		internal static FieldAccessorTable<PushMMPSingleMessage, PushMMPSingleMessage.Builder> internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__FieldAccessorTable;

		// Token: 0x04000015 RID: 21
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__Descriptor;

		// Token: 0x04000016 RID: 22
		internal static FieldAccessorTable<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder> internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__FieldAccessorTable;

		// Token: 0x04000017 RID: 23
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__Descriptor;

		// Token: 0x04000018 RID: 24
		internal static FieldAccessorTable<StartMMPBatchTask, StartMMPBatchTask.Builder> internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__FieldAccessorTable;

		// Token: 0x04000019 RID: 25
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__Descriptor;

		// Token: 0x0400001A RID: 26
		internal static FieldAccessorTable<StartOSBatchTask, StartOSBatchTask.Builder> internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__FieldAccessorTable;

		// Token: 0x0400001B RID: 27
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__Descriptor;

		// Token: 0x0400001C RID: 28
		internal static FieldAccessorTable<SingleBatchRequest, SingleBatchRequest.Builder> internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__FieldAccessorTable;

		// Token: 0x0400001D RID: 29
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__Descriptor;

		// Token: 0x0400001E RID: 30
		internal static FieldAccessorTable<SingleBatchItem, SingleBatchItem.Builder> internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__FieldAccessorTable;

		// Token: 0x0400001F RID: 31
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_PushListMessage__Descriptor;

		// Token: 0x04000020 RID: 32
		internal static FieldAccessorTable<PushListMessage, PushListMessage.Builder> internal__static_com_gexin_rp_sdk_dto_PushListMessage__FieldAccessorTable;

		// Token: 0x04000021 RID: 33
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_EndBatchTask__Descriptor;

		// Token: 0x04000022 RID: 34
		internal static FieldAccessorTable<EndBatchTask, EndBatchTask.Builder> internal__static_com_gexin_rp_sdk_dto_EndBatchTask__FieldAccessorTable;

		// Token: 0x04000023 RID: 35
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_StopBatchTask__Descriptor;

		// Token: 0x04000024 RID: 36
		internal static FieldAccessorTable<StopBatchTask, StopBatchTask.Builder> internal__static_com_gexin_rp_sdk_dto_StopBatchTask__FieldAccessorTable;

		// Token: 0x04000025 RID: 37
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__Descriptor;

		// Token: 0x04000026 RID: 38
		internal static FieldAccessorTable<StopBatchTaskResult, StopBatchTaskResult.Builder> internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__FieldAccessorTable;

		// Token: 0x04000027 RID: 39
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__Descriptor;

		// Token: 0x04000028 RID: 40
		internal static FieldAccessorTable<PushMMPAppMessage, PushMMPAppMessage.Builder> internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__FieldAccessorTable;

		// Token: 0x04000029 RID: 41
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_ServerNotify__Descriptor;

		// Token: 0x0400002A RID: 42
		internal static FieldAccessorTable<ServerNotify, ServerNotify.Builder> internal__static_com_gexin_rp_sdk_dto_ServerNotify__FieldAccessorTable;

		// Token: 0x0400002B RID: 43
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__Descriptor;

		// Token: 0x0400002C RID: 44
		internal static FieldAccessorTable<ServerNotifyResult, ServerNotifyResult.Builder> internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__FieldAccessorTable;

		// Token: 0x0400002D RID: 45
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_OSMessage__Descriptor;

		// Token: 0x0400002E RID: 46
		internal static FieldAccessorTable<OSMessage, OSMessage.Builder> internal__static_com_gexin_rp_sdk_dto_OSMessage__FieldAccessorTable;

		// Token: 0x0400002F RID: 47
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_MMPMessage__Descriptor;

		// Token: 0x04000030 RID: 48
		internal static FieldAccessorTable<MMPMessage, MMPMessage.Builder> internal__static_com_gexin_rp_sdk_dto_MMPMessage__FieldAccessorTable;

		// Token: 0x04000031 RID: 49
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_Transparent__Descriptor;

		// Token: 0x04000032 RID: 50
		internal static FieldAccessorTable<Transparent, Transparent.Builder> internal__static_com_gexin_rp_sdk_dto_Transparent__FieldAccessorTable;

		// Token: 0x04000033 RID: 51
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_PushInfo__Descriptor;

		// Token: 0x04000034 RID: 52
		internal static FieldAccessorTable<PushInfo, PushInfo.Builder> internal__static_com_gexin_rp_sdk_dto_PushInfo__FieldAccessorTable;

		// Token: 0x04000035 RID: 53
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_NotifyInfo__Descriptor;

		// Token: 0x04000036 RID: 54
		internal static FieldAccessorTable<NotifyInfo, NotifyInfo.Builder> internal__static_com_gexin_rp_sdk_dto_NotifyInfo__FieldAccessorTable;

		// Token: 0x04000037 RID: 55
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_ActionChain__Descriptor;

		// Token: 0x04000038 RID: 56
		internal static FieldAccessorTable<ActionChain, ActionChain.Builder> internal__static_com_gexin_rp_sdk_dto_ActionChain__FieldAccessorTable;

		// Token: 0x04000039 RID: 57
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_InnerFiled__Descriptor;

		// Token: 0x0400003A RID: 58
		internal static FieldAccessorTable<InnerFiled, InnerFiled.Builder> internal__static_com_gexin_rp_sdk_dto_InnerFiled__FieldAccessorTable;

		// Token: 0x0400003B RID: 59
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_AppStartUp__Descriptor;

		// Token: 0x0400003C RID: 60
		internal static FieldAccessorTable<AppStartUp, AppStartUp.Builder> internal__static_com_gexin_rp_sdk_dto_AppStartUp__FieldAccessorTable;

		// Token: 0x0400003D RID: 61
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_Button__Descriptor;

		// Token: 0x0400003E RID: 62
		internal static FieldAccessorTable<Button, Button.Builder> internal__static_com_gexin_rp_sdk_dto_Button__FieldAccessorTable;

		// Token: 0x0400003F RID: 63
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_Target__Descriptor;

		// Token: 0x04000040 RID: 64
		internal static FieldAccessorTable<Target, Target.Builder> internal__static_com_gexin_rp_sdk_dto_Target__FieldAccessorTable;

		// Token: 0x04000041 RID: 65
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__Descriptor;

		// Token: 0x04000042 RID: 66
		internal static FieldAccessorTable<SmsContentEntry, SmsContentEntry.Builder> internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__FieldAccessorTable;

		// Token: 0x04000043 RID: 67
		internal static MessageDescriptor internal__static_com_gexin_rp_sdk_dto_SmsInfo__Descriptor;

		// Token: 0x04000044 RID: 68
		internal static FieldAccessorTable<SmsInfo, SmsInfo.Builder> internal__static_com_gexin_rp_sdk_dto_SmsInfo__FieldAccessorTable;
    }
}
