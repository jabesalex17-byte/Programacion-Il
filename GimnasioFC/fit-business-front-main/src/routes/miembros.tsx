import { createFileRoute } from "@tanstack/react-router";
import { AppShell } from "@/components/gym/AppShell";
import { ResourceManager, type FieldDef } from "@/components/gym/ResourceManager";
import { membersApi, type Member } from "@/lib/gym-api";

export const Route = createFileRoute("/miembros")({
  head: () => ({
    meta: [
      { title: "Miembros | GimnasioFC" },
      { name: "description", content: "Alta, edición y baja de los miembros del gimnasio." },
      { property: "og:title", content: "Miembros | GimnasioFC" },
      { property: "og:description", content: "Gestiona los miembros del gimnasio." },
    ],
  }),
  component: Page,
});

const fields: FieldDef<Member>[] = [
  { key: "firstName", label: "Nombre", type: "text" },
  { key: "lastName", label: "Apellido", type: "text" },
  { key: "age", label: "Edad", type: "number" },
  { key: "email", label: "Email", type: "email" },
  { key: "phoneNumber", label: "Teléfono", type: "text" },
  { key: "registrationDate", label: "Fecha de registro", type: "date" },
  { key: "active", label: "Activo", type: "boolean" },
];

function Page() {
  return (
    <AppShell>
      <ResourceManager<Member>
        title="Miembros"
        description="Socios registrados en el gimnasio."
        queryKey="Member"
        api={membersApi}
        fields={fields}
        searchKeys={["firstName", "lastName", "email"]}
      />
    </AppShell>
  );
}
