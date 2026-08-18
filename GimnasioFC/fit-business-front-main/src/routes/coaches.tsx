import { createFileRoute } from "@tanstack/react-router";
import { AppShell } from "@/components/gym/AppShell";
import { ResourceManager, type FieldDef } from "@/components/gym/ResourceManager";
import { coachesApi, type Coach } from "@/lib/gym-api";

export const Route = createFileRoute("/coaches")({
  head: () => ({
    meta: [
      { title: "Coaches | GimnasioFC" },
      { name: "description", content: "Administra los entrenadores, su especialidad y salario." },
      { property: "og:title", content: "Coaches | GimnasioFC" },
      { property: "og:description", content: "Gestiona a los entrenadores del gimnasio." },
    ],
  }),
  component: Page,
});

const fields: FieldDef<Coach>[] = [
  { key: "firstName", label: "Nombre", type: "text" },
  { key: "lastName", label: "Apellido", type: "text" },
  { key: "age", label: "Edad", type: "number" },
  { key: "email", label: "Email", type: "email" },
  { key: "phoneNumber", label: "Teléfono", type: "text" },
  { key: "specialty", label: "Especialidad", type: "text" },
  { key: "salary", label: "Salario", type: "number" },
  { key: "active", label: "Activo", type: "boolean" },
];

function Page() {
  return (
    <AppShell>
      <ResourceManager<Coach>
        title="Coaches"
        description="Entrenadores y sus especialidades."
        queryKey="Coach"
        api={coachesApi}
        fields={fields}
        searchKeys={["firstName", "lastName", "specialty"]}
      />
    </AppShell>
  );
}
