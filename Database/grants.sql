GRANT EXECUTE ON FUNCTION public.certificate_add(name character varying, number character varying, date_begin date, date_end date, id_organization integer) TO certificates_users;

GRANT EXECUTE ON FUNCTION public.certificate_delete(id_certificate integer) TO certificates_users;

GRANT EXECUTE ON FUNCTION public.certificate_edit(id_certificate integer, certificate_name character varying, certificate_number character varying, certificate_date_begin date, certificate_date_end date, certificate_id_organization integer) TO certificates_users;

GRANT EXECUTE ON FUNCTION public.certificate_get_registry() TO certificates_users;

GRANT EXECUTE ON FUNCTION public.organization_add(name character varying) TO certificates_users;

GRANT EXECUTE ON FUNCTION public.organization_delete(id_organization integer) TO certificates_users;

GRANT EXECUTE ON FUNCTION public.organization_get_all() TO certificates_users;

GRANT ALL ON SEQUENCE public.certificates_id_seq TO certificates_users;

GRANT ALL ON SEQUENCE public.organization_id_seq TO certificates_users;

GRANT ALL ON TABLE public.certificate TO certificates_users;

GRANT ALL ON TABLE public.organization TO certificates_users;