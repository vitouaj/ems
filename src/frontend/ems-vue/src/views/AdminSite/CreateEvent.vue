<template>
  <div>
    <v-card>
      <v-card-title class="font-weight-bold" style="color: #004b8d">New Event</v-card-title>
      <v-card-text>
        <v-row>
          <v-col cols="12" class="pb-0">
            <label for="eventName" class="labelText">Event Name</label><br />
            <text-field placeholder="e.g name of event" v-model="eventName"></text-field>
          </v-col>
          <v-col cols="6" class="mb-2">
            <label for="startDate" class="labelText">Start Date</label><br />
            <input type="date" v-model="startDate" />
          </v-col>
          <v-col cols="6" class="pb-0">
            <label for="eventSessions" class="labelText">Event Sessions</label><br />
            <session-diol v-model="eventSessions" />
          </v-col>
          <v-col cols="6" class="mb-2">
            <label for="endDate" class="labelText">End Date</label><br />
            <input type="date" v-model="endDate" />
          </v-col>
          <v-col cols="12" class="pb-0">
            <label for="description" class="labelText">Description</label><br />
            <v-textarea
              row-height="20"
              rows="2"
              auto-grow
              variant="solo"
              placeholder="type your description here..."
              v-model="description"
            ></v-textarea>
          </v-col>
          <v-col cols="12" class="pb-0">
            <label for="map" class="labelText">Map</label><br />
            <text-field placeholder="type your location" v-model="map"></text-field>
          </v-col>
          <v-col cols="6">
            <label for="tag" class="labelText">Tag</label><br />
            <v-autocomplete
              v-model="tags"
              :items="items"
              density="compact"
              variant="solo"
              multiple
            ></v-autocomplete>
          </v-col>
          <v-col cols="6">
            <label for="participator" class="labelText">Participator</label><br />
            <text-field placeholder="enter participator" v-model="participator"></text-field>
          </v-col>
          <v-col cols="12">
            <label for="image" class="labelText">Image</label><br />
            <v-file-input
              variant="solo"
              density="compact"
              label="add image"
              prepend-icon=""
              v-model="image"
            ></v-file-input>
          </v-col>
        </v-row>
      </v-card-text>
      <v-card-actions class="d-flex justify-end">
        <v-btn variant="elevated" color="#004B8D">Discard</v-btn>
        <v-btn variant="elevated" color="#FF7F00" @click="onSubmit">Post</v-btn>
      </v-card-actions>
    </v-card>
  </div>
</template>

<script>
import SessionDiol from './components/SessionDiol.vue'
import TextField from './components/TextField.vue'
import { ref } from 'vue'

export default {
  setup() {
    const eventName = ref('')
    const startDate = ref('')
    const endDate = ref('')
    const description = ref('')
    const map = ref('')
    const tags = ref([])
    const participator = ref('')
    const image = ref(null)
    const eventSessions = ref([])

    async function onSubmit() {
      const eventDetails = {
        name: eventName.value,
        description: description.value,
        numberOfParticipant: participator.value,
        categoryId: tags.value,

        startDate: startDate.value,
        endDate: endDate.value,
        map: map.value,
        tags: tags.value,
        image: image.value,
        eventSessions: eventSessions.value
      }
      console.log(eventDetails)
    }

    return {
      eventName,
      startDate,
      endDate,
      description,
      map,
      tags,
      participator,
      image,
      eventSessions,
      onSubmit
    }
  },

  components: {
    TextField,
    SessionDiol
  },
  data: () => ({
    items: ['education', 'workshop', 'fizz', 'buzz'],
    values: 'education'
  })
}
</script>
