<template>
  <div>
    <v-card>
      <v-card-title class="font-weight-bold" style="color: #004b8d">New Event</v-card-title>
      <v-card-text>
        <v-row>
          <v-col cols="6" class="pb-0">
            <label for="eventName" class="labelText">Event Name</label><br />
            <text-field placeholder="" v-model="eventName"></text-field>
          </v-col>
          <v-col cols="6">
            <label for="tag" class="labelText">Category</label><br />
            <select v-model="selectedCategory" id="options">
              <option v-for="option in categoryOptions" :key="option.id" :value="option.id">
                {{ option.name }}
              </option>
            </select>
          </v-col>
          <v-col cols="6" class="mb-2">
            <label for="startDate" class="labelText">Start Date</label><br />
            <input type="date" v-model="startDate" />
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
          <v-col cols="6" class="pb-0">
            <label for="map" class="labelText">Venue</label><br />
            <select v-model="selectedVenue" id="options">
              <option v-for="option in venueOptions" :key="option.id" :value="option.id">
                {{ option.name }}
              </option>
            </select>
          </v-col>

          <v-col cols="6">
            <label for="participator" class="labelText">Participator</label><br />
            <input id="number-input" type="number" v-model="participator" />
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
import axios from 'axios'
import SessionDiol from './components/SessionDiol.vue'
import TextField from './components/TextField.vue'
import { ref, onMounted } from 'vue'

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

    const categoryOptions = ref([])
    const selectedCategory = ref(null)

    const venueOptions = ref([])
    const selectedVenue = ref(null)

    async function getCategoryOptions() {
      try {
        const categoryResponse = await axios.get('http://localhost:4001/api/v1/event/category')
        categoryOptions.value = categoryResponse.data
        console.log(categoryOptions.value)
      } catch (error) {
        console.error('Failed to fetch categories:', error)
      }
    }

    async function getVenueOptions() {
      try {
        const venueRes = await axios.get('http://localhost:4001/api/v1/event/venue')
        venueOptions.value = venueRes.data
        console.log(venueOptions.value)
      } catch (error) {
        console.error('Failed to fetch categories:', error)
      }
    }

    onMounted(() => {
      getCategoryOptions()
      getVenueOptions()
    })

    async function onSubmit() {
      const eventDetails = {
        name: eventName.value,
        description: description.value,
        numberOfParticipant: participator.value,
        categoryId: selectedCategory.value,
        venueId: selectedVenue.value,
        startDate: startDate.value,
        endDate: endDate.value,
        map: map.value,
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
      onSubmit,
      categoryOptions,
      selectedCategory,
      venueOptions,
      selectedVenue
    }
  },

  components: {
    TextField
  },
  data: () => ({
    items: ['education', 'workshop', 'fizz', 'buzz'],
    values: 'education'
  })
}
</script>
<style scoped>
#options {
  width: 100%;
  height: 2.6rem;
  border-color: rgb(201, 201, 201);
  color: black;
  -webkit-appearance: button;
  border-radius: 5px;
  border-style: solid;
}

#number-input {
  width: 100%;
  height: 2.6rem;
  color: black;
  -webkit-appearance: none;
  border-radius: 5px;
  border-color: rgb(224, 224, 224);
  border-style: solid;
}
</style>
